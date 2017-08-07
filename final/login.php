<?php
	/*
		This script does one of 3 things:
			1. If the user is visiting for their first time, present a login form
			2. If the login was submitted, process the credentials (username/password)
				Success = Set a cookie and redirect to page1.php
				Failure = Present the login form again with an error
			3. If the user is already logged in, redirect them to page1.php
	*/

	// Pull username from $_COOKIE, if it exists
	$username = empty($_COOKIE['username']) ? '' : $_COOKIE['username'];
	
	// If the user is logged in, redirect them home
	if ($username) {
		header("Location: index.html");
		exit;
	}
	
	
	// Pull out any "action" from $_POST
	$action = empty($_POST['action']) ? '' : $_POST['action'];
	
	if ($action == 'do_login') {
		// If the action is "do_login", then the form was submitted
		handle_login();
	} else {
		// Else, the form wasn't submitted, so present the login
		login_form();
	}
	
	function handle_login() {
		$username = empty($_POST['username']) ? '' : $_POST['username'];
		$password = empty($_POST['password']) ? '' : $_POST['password'];
	
		if ($username == "test" && $password == "pass") {
			setcookie('username', $username, 0, '/~cjbq4f/cs2830/final/');
			header("Location: index.html");
			exit;
		} else {
			$error = 'Login failed.  Please enter your username and password.';
			require "login_form.php";
			print $error;
		}		
	}
	
	function login_form() {
		$username = "";
		$error = "";
		require "login_form.php";
	}
	
?>