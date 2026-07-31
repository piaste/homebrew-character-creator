### Task: Synchronize Game Entities with Google Docs Documentation

**Objective**: Update the game entities encoded in the repository to match the latest documentation found in the project's Google Docs and Google Sheets. Your schedule will specify which entities should be updated.

**Resources**:
- **Index Page**: [Starting Guide : Homebrew](https://docs.google.com/document/d/1u-URJyBh-IDHQ27XyQ9Gu_jG2aEQip-vMjTS5QjLCk8)
- **Entity Files**: Located in `src/Domain/Entities/` (e.g., `Classes.fs`, `Spells.fs`, `Feats.fs`, etc.)

**Instructions**:

1.  **Access Documentation**:
    *   Start from the **Index Page** above and look for the documents describing the entities you care about.
    *   For **Google Docs** links (Classes, Races, Feats, etc.), access them using the Markdown export format by appending `/export?format=md` to the document URL.
    *   For **Google Sheets** links (specifically **Spells & Cantrips**, and **Equipment and Weapons**), access them using the CSV export format. Each sheet can be exported as CSV by using `/export?format=csv&gid=[GID]` for the relevant tab (e.g., gid 1414579635 for Cantrips).

**Mapping Reference**:
*   `Classes.fs` & `Subclasses.fs` -> Individual Class links (Artificer, Barbarian, etc.)
*   `SpecialPicks.fs` -> Individual special abilities inside each Class doc
*   `Spells.fs` & `Cantrips.fs` -> "Spells & Cantrips" Sheet link
*   `Feats.fs` -> "Feats" Doc link
*   `BaseRaces.fs` & `Subraces.fs` -> "Races" Doc link
*   `Archetypes.fs` -> "Archetypes" Doc link
*   `Traits.fs` -> "Traits" Doc link
*   `Skills.fs` -> "Skills" section in the Main Doc or linked page
*   `Equipment.fs` ->  "Items: Equipment" Sheet link
*   `Weapons.fs` ->  "Items: Weapons" Sheet link

2.  **Verify existing PRs**:    
    * Check the repository's open PRs. If any open PRs include changes to one or more Entities files, exclude those files from the rest of the task.

2.  **Compare and Synchronize**:
    *   Analyze each documentation page and compare the entities described there with the F# objects defined in the corresponding file in `src/Domain/Entities/`.
    *   **Add** any new entities found in the documentation that are missing from the code.
    *   **Update** existing entities in the code if their values (Name, Description, Action Costs, etc.) have changed in the documentation.
    *   **Remove** any entities from the code that are no longer present in the documentation.
    *   Only modify an entity if its content differs from the documentation. Do not rewrite, reformat, or rephrase entities that already match the source — even if you think the wording could be improved. Stylistic-only edits with no informational change are out of scope and must not be included in the PR.

3.  **Strict Constraints**:
    *   **Do NOT** change the structure of the code, the file organization, or the underlying F# types (defined in `src/Domain/Types.fs`).    
    *   Only modify the values and instances of the objects. Only touch files under `src/Domain/Entities`.
    *   Preserve the existing order and formatting of entities in each file. Do not reorder, re-indent, or reformat code outside the specific lines being changed.
    *   Use existing constants and patterns (e.g., `Simple "Ability"`, `ACTION`, `BONUS_ACTION`) as seen in the current files.
    *   Prefer using `Power`and `Buff` types if possible, then `Complex` whenever the passive being described has a proper name in the documentatikn. Only use `Simple` if it is impossible to write a `Complex` power.
    *   Make descriptions shorter and concise where possible without losing substantial information. For example, if a description reads "Your maximum Hit Points increases by 4 for each level you have gained.", you can replace it with "+4 HP per level". This conciseness rule applies only when writing a new or changed description to match updated documentation. Do not proactively edit descriptions that are unchanged from the documentation just to make them shorter.
    *   **Do** update entities' names to be in line with the documentation.
    *   **Do not** change the value of entities `Id` or `TypeId` property.

4.  **Specific rules**:
    *   All strings preceded by '<?>' are LORE STRINGS that you must never touch.
    *   Feats and passives marked in the documents with "*" also affect summons. To represent that, add "yield! alsoAffectsSummons <|" before each passive they grant. (See 'divineSense' in 'classPassives.fs' for reference.)

5.  **Verification**:
    *   After making changes to a file, run `dotnet build src/Bg3HomebrewCCreator.Client.fsproj` to ensure that the strict typing is respected and there are no compile-time errors.
    
6.  **PR Management**:
    *   **Committed Files**: Any scripts, notebooks, or scratch files created to assist with fetching or parsing documentation are temporary working files and must never be committed. Before opening or updating a PR, run git status and confirm the diff contains changes only to files under src/Domain/Entities/. Remove or git clean anything else first.
    *   **PR Summary**: The PR description (or the new commit message if updating an existing PR) must include a **plain-language summary** of the changes, specifically listing the names of the entities that were added, updated, or removed.
    *   **Human Guidance**: If you need clarification or human guidance on any task, do **NOT** ask questions in interactive chat. Instead, make your best effort to implement the changes, submit the code by opening a Pull Request (PR) from a new branch, and explain your questions or choices in the PR description or comments so that the human reviewer can provide feedback directly on the PR. Never pause and wait for user confirmation before creating or updating a PR. Never ask "should I proceed" or equivalent. Opening the PR is your default action once changes are made — the PR itself is the checkpoint for human review, not chat.
    *   **No-Change scenario**: If you did not find anything in need of update and thus your PR contains no changes, abort and do not create any PR.

