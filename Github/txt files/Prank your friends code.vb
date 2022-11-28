Write this code first-
X=MsgBox("Message Description",0+16,"Title") 

use this code to prank your someone

0 = OK Button, 
1 = OK / Cancel Button, 
2 = Abort / Retry / Ignore Button, 
3 = Yes / No / Cancel Button, 
4 = Yes / No Button, 
5 = Retry / Cancel Button

16 = Critical Icon, 
32 = Help Icon, 
48 = Warning Icon, 
64 = Information Icon,

these numbers are icons

this is a demonstration

Type the above code in Notepad and save this notepad on your desktop, Give it some convincing name like
 “My Computer” and Save the file as .vbs  extension, and select all files instead of *txt. 
 Like My Computer.vbs

In above Code  X=MsgBox(“Message Description”,0+16,”Title”)  here is the explanation of this code.

Message Description  – This is what you want to show as a Message.
Button – Type of button, like OK, Yes, No, Cancel, etc
Icon – Type of icon you want to show like Info icon, critical icon, etc
Title – Title of message Box.

You can write any number from 1,2,3 or 4 instead of 0 (before the ‘+’ symbol)
Here is the meaning of these numbers:

0 = OK Button,
1 = OK / Cancel Button,
2 = Abort / Retry / Ignore Button,
3 = Yes / No / Cancel Button,
4 = Yes / No Button,
5 = Retry / Cancel Button

You can write 32 or 48 or 64 instead of 16.
Here is the meaning of each number:
16 = Critical Icon,
32 = Help Icon,
48 = Warning Icon,
64 = Information Icon,


this is the code:

X=MsgBox("Error while opening Computer. Do you want to Fix this Error?",4+64,"Computer")
X=MsgBox("Unable to Fix this Error. Do you want to scan this Computer",3+48,"Computer")
X=MsgBox("Alert ! Virus Detected. Delete Virus? ",3+16,"Alert!")
X=MsgBox("Unable to delete this Virus",1+64,"Critical Error")
X=MsgBox("Virus Is activated",2+16,"Alert")
X=MsgBox("Deleling System Files.....",2+16,"File Deletion")
X=MsgBox("Virus is copying your password.....",2+48,"Virus Alert")
X=MsgBox("Please Wait, Uploading your data to Server. Do you want to Stop it",4+64,"File Transfer")
X=MsgBox("Could not stop. File Transfer Completed",1+16,"Completed")
X=MsgBox("Your Computer is Hacked",0+64,"Alert")
X=MsgBox("HAHA This was Prank",0+64,"Fooled You")