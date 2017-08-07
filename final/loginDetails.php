<?php
	$username = $_COOKIE['username'];
	print "You are logged in as " . "<strong>" . $username . "</strong>\n<br>";
	print "Everything is now draggable! Yaaaaaaay!";
?>
<p class="logoutWrapper"><a href="logout.php" id="logoutButton" class="logoutButton">Logout</a></p>