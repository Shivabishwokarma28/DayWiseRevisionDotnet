# DayWiseRevisionDotnet
Revision of code and better understanging
Git and GitHub are the bread and butter of modern software development. Think of Git as your personal "Time Machine" for code on your computer, and GitHub as the "Cloud Storage and Collaboration Hub" where that time machine is backed up and shared.



1. The Core Concepts
  -> Before jumping into commands, it helps to visualize the three "stages" of Git:


  -> Working Directory: Your actual folder where you edit files (e.g., DayWiseRevisionDotnet).


  -> Staging Area (The Index): A "prep zone" where you pick which changes are ready to be saved.


  -> Local Repository: The .git folder that stores your permanent "save points" (commits).


  -> Remote Repository: The version hosted on GitHub.

2. Essential Commands & Explanations
Starting a Project
Command	What it does

  -> git init	Transforms a regular folder into a Git repository (creates the hidden .git folder).

  -> git clone <url>	Downloads an existing project from GitHub to your computer.
The Daily Workflow (Save & Upload)
These are the commands you will use 90% of the time.


  -> git status

Explanation: Your best friend. It tells you which files are modified, which are in the staging area, and what branch you are on.


  -> git add <file>

Explanation: Moves a file to the "Staging Area." Use git add . to add everything in the folder.


  -> git commit -m "your message"

Explanation: Creates a permanent snapshot of your staged changes. The message should be descriptive (e.g., "Add Day 5 logic").


  -> git push origin <branch_name>

Explanation: Sends your local commits to GitHub.

3. Handling Branches
   
Branches allow you to work on different tasks (like Day 1 vs. Day 5) without making a mess.


  -> git branch: Lists all your local branches.


  -> git checkout -b <name>: Creates a new branch and switches to it immediately.


  -> git checkout <name>: Switches back to an existing branch.


  -> git merge <name>: Combines work from another branch into your current one.

4. Staying Synced
If you work on a different computer or change files directly on GitHub, you need to update your local files.


  -> git fetch: Sees if there are updates on GitHub but doesn't change your files yet.


  -> git pull: Downloads changes from GitHub and merges them into your local files immediately.

5. Summary Checklist for your "DayWise" Project
When you finish a new day of coding, follow this exact sequence:


  -> git checkout -b Day_X (Start a new branch for the new day).


  -> git add Day_X/ "Notes.docx" (Stage your specific folder and files).


  -> git commit -m "Finished Day X" (Save the snapshot).


  -> git push origin Day_X (Upload to GitHub).

  -> git rm -r --cached Day_1/ Day_2/ Day_3/ Day_4/ "Keep these folders on my computer, but stop tracking them in this specific branch."
  
The Anatomy of the Command
  -> git rm: The "remove" command.

  -> -r: Stands for recursive. It tells Git to go inside the folders and remove every file and subfolder within them.

  -> --cached: This is the most important part. It tells Git to only remove the files from the Git Index (the tracker), not from your hard drive. Without this, your actual code files would be deleted!

  -> Day_1/ ...: These are the specific targets you want Git to stop watching.

Common Pitfalls to Avoid
Nested Git Folders: Never run git init inside a subfolder if the parent folder already has one. It creates the "does not have a commit checked out" error we saw earlier.

Case Sensitivity: Git is picky. Csharp_Notes.docx is not the same as csharp_notes.docx in many environments.

Forgotten Extensions: Always include .docx, .pdf, or .cs when adding individual files.
