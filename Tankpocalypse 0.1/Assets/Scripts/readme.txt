Note for the Database Developer
For Scene SignUp;
	How to retrive username, email and password:
	------------------------------------
	go to MainCamera, it has a file called 'SignUpFile.cs'
	There is a function to get userinputs from the textbox.
	You can use that function to retive username, password, 
	email. Then send those to database. 

For Scene LogIn:
	How to retrive username and password:
	------------------------------------
	go to the MainCera, it has a file called 'GetLoginInfo.cs'
	Check that for the function that will retrive the user inputs.
	You can get username and password and send to DB.
	
	Sample local Account Info validate checker function
	--------------------------------------------------
	I created a file, and put some usernames and passwords.
	And created a sample function for account validation.
	It might be useful.

For Scene LeaderBoard:
	Check LeaderBoard.cs script, I have a made a function that will read from
	a file and pupulate the leaderboard. You can change that and make it
	read from that DB.
