import re

with open("feats.txt", "r", encoding="utf-8") as f:
    doc_content = f.read().replace("\r\n", "\n")

# Extract blocks from the doc, separated by underscores
blocks = doc_content.split("________________")

doc_feats = {}
for block in blocks:
    lines = [l.strip() for l in block.split("\n") if l.strip()]
    if not lines:
        continue
    title = None
    desc_parts = []
    for line in lines:
        if line.isupper() and len(line) > 2 and "THIS DOCUMENT" not in line and "FEATS" != line:
            title = line.strip().upper()
        elif title:
            desc_parts.append(line)
    if title:
        doc_feats[title] = " ".join(desc_parts)

with open("src/Domain/Entities/Feats.fs", "r", encoding="utf-8") as f:
    fs_content = f.read()

# Let's extract each feat and compare
feat_blocks = re.findall(r"let rec (\w+) : FeatDef = \{(.*?)\n\}", fs_content, re.DOTALL)

print(f"Total feats in doc: {len(doc_feats)}")
print(f"Total feats in code: {len(feat_blocks)}")

mismatches = 0
for name, body in feat_blocks:
    name_match = re.search(r'Name\s*=\s*"([^"]+)"', body)
    if not name_match:
        continue
    feat_name = name_match.group(1)
    feat_name_upper = feat_name.upper().replace("’", "'").replace("‘", "'")

    # Let's search in doc_feats by stripping non-alpha characters for robust matching
    clean_code_name = "".join(c for c in feat_name_upper if c.isalnum())
    matched_doc_key = None
    for k in doc_feats:
        clean_doc_key = "".join(c for c in k if c.isalnum())
        if clean_code_name == clean_doc_key:
            matched_doc_key = k
            break

    if not matched_doc_key:
        print(f"MISSING IN DOC: {feat_name}")
        mismatches += 1
        continue

    doc_text = doc_feats[matched_doc_key]

    # Gather F# text
    fs_grants = []
    grants = re.findall(r'Complex \("[^"]+",\s*"([^"]+)"\)', body)
    powers = re.findall(r'Power \([^)]+,\s*"([^"]+)",\s*"([^"]+)"\)', body)
    powers_short = re.findall(r'Power \([^)]+,\s*"([^"]+)"\)', body)

    for g in grants:
        fs_grants.append(g)
    for p_title, p_desc in powers:
        fs_grants.append(p_desc)
    for p_desc in powers_short:
        fs_grants.append(p_desc)

    explicit_match = re.search(r'ExplicitDescription\s*=\s*Some\s*"([^"]+)"', body)
    if explicit_match:
        fs_grants.append(explicit_match.group(1))

    # See if any of the key phrases in the doc are missing from F# grants
    # Let's normalize text for comparison
    def clean(t):
        t = t.lower()
        # Remove actions symbols and weird chars
        t = re.sub(r'[^a-z0-9]', '', t)
        return t

    doc_clean = clean(doc_text)
    code_clean = "".join(clean(g) for g in fs_grants)

    # We expect code_clean to cover most keywords, or if not, let's see.
    # Since F# descriptions are split or phrased slightly differently, let's print them if clean length ratio differs significantly
    ratio = len(code_clean) / max(1, len(doc_clean))
    if ratio < 0.6 and "select two" not in doc_text.lower():
        print(f"POTENTIAL MISMATCH: {feat_name}")
        print(f"  Doc:  {doc_text}")
        print(f"  Code: {' | '.join(fs_grants)}")
        mismatches += 1

print(f"Total mismatches found: {mismatches}")
