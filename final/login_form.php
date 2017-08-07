<form id="loginForm" name="Login" action="login.php" method="POST">
	<input type="hidden" name="action" value="do_login">
	<br>
	<label for="username">User name:</label>
	<input type="text" name="username" id="username" value="<?php print $username; ?>">
	<br>
	<label for="password">Password:</label>
	<input type="password" name="password" id="password">
	<br>
	<input type="submit" name="submit" value="Submit">
</form>