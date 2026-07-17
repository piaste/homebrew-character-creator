### Task: Synchronize Game Entities with Google Docs Documentation

**Objective**: Update the game entities encoded in the repository to match the latest documentation found in the project's Google Docs and Google Sheets. Your schedule will specify which entities should be updated.

**Resources**:
- **Index Page**: [Starting Guide : Homebrew](https://docs.google.com/document/d/1u-URJyBh-IDHQ27XyQ9Gu_jG2aEQip-vMjTS5QjLCk8)
- **Entity Files**: Located in `src/Domain/Entities/` (e.g., `Classes.fs`, `Spells.fs`, `Feats.fs`, etc.)

**Instructions**:

1.  **Access Documentation**:
    *   Start from the **Index Page** above and look for the documents describing the entities you care about.
    *   For **Google Docs** links (Classes, Races, Feats, etc.), access them using the Markdown export format by appending `/export?format=md` to the document URL.
    *   For **Google Sheets** links (specifically **Spells & Cantrips**), access them using the CSV export format. The Spells & Cantrips sheet can be exported as CSV by using `/export?format=csv&gid=[GID]` for the relevant tab (e.g., gid 1414579635 for Cantrips).

**Mapping Reference**:
*   `Classes.fs` & `Subclasses.fs` -> Individual Class links (Artificer, Barbarian, etc.)
*   `SpecialPicks.fs` -> Individual special abilities inside each Class doc
*   `Spells.fs` & `Cantrips.fs` -> "Spells & Cantrips" Sheet link
*   `Feats.fs` -> "Feats" Doc link
*   `BaseRaces.fs` & `Subraces.fs` -> "Races" Doc link
*   `Archetypes.fs` -> "Archetypes" Doc link
*   `Traits.fs` -> "Traits" Doc link
*   `Skills.fs` -> "Skills" section in the Main Doc or linked page

2.  **Verify existing PRs**:    
    * Check the repository's open PRs. If any open PRs include changes to one or more Entities files, exclude those files from the rest of the task.

2.  **Compare and Synchronize**:
    *   Analyze each documentation page and compare the entities described there with the F# objects defined in the corresponding file in `src/Domain/Entities/`.
    *   **Add** any new entities found in the documentation that are missing from the code.
    *   **Update** existing entities in the code if their values (Name, Description, Action Costs, etc.) have changed in the documentation.
    *   **Remove** any entities from the code that are no longer present in the documentation.

3.  **Strict Constraints**:
    *   **Do NOT** change the structure of the code, the file organization, or the underlying F# types (defined in `src/Domain/Types.fs`).    
    *   Only modify the values and instances of the objects. Only touch files under `src/Domain/Entities`.
    *   Use existing constants and patterns (e.g., `Simple "Ability"`, `ACTION`, `BONUS_ACTION`) as seen in the current files.
    *   Prefer using `Power`and `Buff` types if possible, then `Complex` whenever there is a valid name. Only use `Simple` if `Complex` is impossible to write.
    *   Make descriptions shorter and concise where possible without losing information. For example, if the documentation reads "Your maximum Hit Points increases by 4 for each level you have gained.", you can replace it with "+4 HP per level".    
    *   **Do NOT** change the content of descriptions and summaries unless they are factually incorrect. That is, do not update text purely for reasons of style.
    *   **Do** update entities' names to be in line with the documentation.

4.  **Verification**:
    *   After making changes to a file, run `dotnet build src/Bg3HomebrewCCreator.Client.fsproj` to ensure that the strict typing is respected and there are no compile-time errors.
    
5.  **PR Management**:
    *   **PR Summary**: The PR description (or the new commit message if updating an existing PR) must include a **plain-language summary** of the changes, specifically listing the names of the entities that were added, updated, or removed.
    *   **Human Guidance**: If you need human guidance or clarification on ambiguous documentation, do not ask questions in chat. Instead, open a Pull Request (PR) and use the PR description or comments to ask your questions and request feedback.

