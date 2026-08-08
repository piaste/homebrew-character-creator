with open("temp_docs/Fighter.txt", "r") as f:
    text = f.read()

lines = text.splitlines()
for i, line in enumerate(lines):
    if "learn" in line and "infusion" in line.lower():
        print(f"{i}: {line}")
