//wait for DOM to load
$(function() {
	/* Calls the tabs function through jquery ui to set up the main content of the website in 'tabs' */
	$("#tabs").tabs();
	/* Loads the header section of each page. Includes Shana Prusha's Portfolio and the navigation bar */
	$(".ajaxHeader").load("ajaxTopHeader.html");
	/* Loads the login form to each site so user can login from any section */
	$(".loginDiv").load("login_form.php");

	$(".loginDetails").load("loginDetails.php");

	/* Checks for cookie named 'username'. If found, hides the login form and shows details, such as username or a welcome message */
	if($.cookie('username')) {
		$(".loginDiv").hide();
		$(".loginDetails").show();
		$("*").draggable();
	}
});