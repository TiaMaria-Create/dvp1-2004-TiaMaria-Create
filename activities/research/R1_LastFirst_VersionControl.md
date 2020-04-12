

## PROJECT AND PORTFOLIO I: DEVELOPMENT ONLINE

* **IMPACT OF VERSION CONTROL**
* **TYKEEJA HARRIS**
* **4/10/2020**

This research paper summarizes my time and effort looking into the topic matter outlined below. I have included links and references to research information used for this activity.    

## Topic: Terminal
Professional developers use Terminal daily. It's essential to understand some fundamental commands to use the application. Here's what I have learned...  

**1. Using Terminal, there are essential Linux commands I must know.**

```
* **CLEAR** : Clear the Screen 
* **PWD** : Print the "Working Directory" Displays the current directory or folder the user is browsing.
* **LS** : List files and folders
* **LS -LA** : List files and folders, including invisible files
* **LS -LH** : List all files and folders, in human readable form
* **CD** : Change directory
* **CD /** : Change directory, go to root directory
* **CD ~** :  Change directory and go to user home directory. Best practice to always make sure user is in the right place.
* **CD ..** : Change directory, go up one folder level
* **CD .. /..** : Change directory, go up two folder levels
* **cd ~/Desktop/**: Change directory to my desktop! 
```

If any further assistance is needed with any command, run it with the --help option and it will provider further information and documentation. ("21 Simple ls Command Examples For Linux", 2016)

**2. After Trying this in Terminal, I learned...**

**Folder Drop:** 
An easy way to navigate to a folder, that may be tedious to access one line at a time is to type 'cd [space]' into the terminal and drag the folder directly into the terminal. The path of the folder will be displayed after the cd command. Press enter and the command will be executed. This is a quick way to navigate deep or buried files.



## Topic: Version Control & Git
Version control, also known as revision control, records changes to a file or set of files over time so that you can recall specific versions later. In this class, we are learning Git. Here's what I have learned. 

**1. There are three types of version control.**

There are three types of version control, Local, Centralized, and Distributed. Local version control is a system to maintain track of worked on files on a local system. This approach is very common but it is also incredibly error prone. It is easy for users to forget which directory they are on in and accidentally write to the wrong file. ("Learn The Three Different Types Of Version Control Systems", 2018)

In the Centralized version control system all changes in the files are tracked under a centralized server. The centralized server includes all the information of versioned files, and list of clients that check out files from that central place. ("Learn The Three Different Types Of Version Control Systems", 2018)

Distributed version control systems completely clone the repository of files including the full edit history. This system gives each user a full backup of all of the data.



**2. Using Terminal, there are essential Git commands I must know.**

[ Student Response: List the correct Git commands to do the actions listed below in Terminal. Replace CMD with the correct command and keep or enhance the brief description. **The last bullet provides an example**. 

```
* **git clone**: Clone a repository
* **git config --global user.name**: Set-up a global user name
* **git config --global user.email"[valid-email]"**: Set-up a global email address (to match my GitHub account eMail)
* **git status**: Show modified files
* **git add [file]**: Add modified files to the next commit
* **git commit -m "[message]"**: Make a commit with a new message
* **git log**: Show my commit history
* **git help**: This command will bring up Git's help screen in Terminal!
```
    
When submitting commits its a good practice is to remember to commit often and review whatever it is you've completed (testing code, making sure there are no typos in a design, ect). Write good ,detailed yet brief commit messages that explains what change you made, and employ good formatting habits. ("Trein/dev-best-practices", 2018)


**3. Authenticating with GitHub from Git.**

Before you begin, you'll need to download and install GIT on your machine. At this step you can also create your personal access token for use later on. In your GitHub profile click settings> developer setting>personal access tokens. Then click generate new token. Save this token to your computer for future use. Next you want to set up your username in Git and your email address using the commands we already researched above. Next before we connect we need to authenticate with Github using HTTPS.("Which remote URL should I use? - GitHub Help", n.d.) On the GitHub website, select clone or download on the home screen of your working repository. Copy the url and use the command git clone, and paste the url into the terminal and run the command. Git will ask for your username and password to authenticate your access to the repository. Enter the email address used with your GitHub profile. Paste the personal access token you created earlier in the password field. You will now be allowed to navigate and modify the downloaded repository. 


**4. .gitignore**  

The purpose of .gitignore files, is to encourage Git to ignore those files prevent the files from being edited by any user. These are usually, personal IDE config files, compiled code, files generated at run time or hidden system files such as a .Ds_Store file, which is a file that contains the custom attributes of the folder, such as a background image or the position of the icons. The purpose of the file is to hold custom view settings for that particular folder. If the file is deleted those settings may be deleted. If you want to ignore a file that you've committed in the past, you'll need to delete the file from the repository and then add a .gitignore rule for it.Using the --cached option with git rm means that the file will be deleted from your repository, but will remain in your working directory as an ignored file (".gitignore file - ignoring files in Git | Atlassian Git Tutorial", 2020).


<br>

# References


21 Simple ls Command Examples For Linux. (2016). Retrieved 15 March 2020, Retrieved from https://www.rootusers.com/21-simple-ls-command-examples-for-linux/

Learn The Three Different Types Of Version Control Systems. (2018). Retrieved 15 March 2020, Retrieved from https://blog.eduonix.com/software-development/learn-three-types-version-control-systems/

Trein/dev-best-practices. (2017). Retrieved 15 March 2020, from https://github.com/trein/dev-best-practices/wiki/Git-Commit-Best-Practices

Which remote URL should I use? - GitHub Help. Retrieved 15 March 2020, Retrieved from https://help.github.com/en/github/using-git/which-remote-url-should-i-use#cloning-with-https-urls-recommended

.gitignore file - ignoring files in Git | Atlassian Git Tutorial. (2020). Retrieved 15 March 2020, Retrieved from https://www.atlassian.com/git/tutorials/saving-changes/gitignore


