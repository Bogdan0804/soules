<!DOCTYPE HTML>
<html>
	<head>
	<meta charset="utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">

	<title>Souless</title>
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<meta name="description" content="Souless RPG" />
	<meta name="author" content="bogz" />


	<link href="https://fonts.googleapis.com/css?family=Space+Mono" rel="stylesheet">
	
	<!-- Animate.css -->
	<link rel="stylesheet" href="css/animate.css">
	<!-- Icomoon Icon Fonts-->
	<link rel="stylesheet" href="css/icomoon.css">
	<!-- Bootstrap  -->
	<link rel="stylesheet" href="css/bootstrap.css">

	<!-- Magnific Popup -->
	<link rel="stylesheet" href="css/magnific-popup.css">

	<!-- Flexslider  -->
	<link rel="stylesheet" href="css/flexslider.css">

	<!-- Theme style  -->
	<link rel="stylesheet" href="css/style.css">

	<!-- Modernizr JS -->
	<script src="js/modernizr-2.6.2.min.js"></script>
	<!-- FOR IE9 below -->
	<!--[if lt IE 9]>
	<script src="js/respond.min.js"></script>
	<![endif]-->

	</head>
	<body>
		
	<div class="fh5co-loader"></div>
	
	<div id="page">
	<nav class="fh5co-nav" role="navigation">
		<div class="top-menu">
			<div class="container-fluid">
				<div class="row">
					<div class="col-xs-2">
						<div id="fh5co-logo"><a href="index.html">SOULESS<span>.</span></a></div>
					</div>
					<div class="col-xs-10 text-right menu-1">
						<ul>
							<li><a href="index.php">Home</a></li>
							<li class="active">
								<a href="game.php">Game</a>
							</li>
							<li><a href="dev.php">Development</a></li>
						</ul>
					</div>
				</div>
				
			</div>
		</div>
	</nav>

	<aside id="fh5co-hero" class="js-fullheight">
		<div class="flexslider js-fullheight">
			<ul class="slides">
		   	<li class="holder" style="background-image: url(images/img_bg_1.jpg);">
		   		<div class="overlay-gradient"></div>
		   		<div class="container">
		   			<div class="col-md-10 col-md-offset-1 text-center js-fullheight slider-text">
		   				<div class="slider-text-inner desc">
		   					<h2 class="heading-section">Game</h2>
		   					<p class="fh5co-lead">Souless RPG is a roguelike RPG game inspired by older text based dungeon crawlers(in which you explore a farily limited world with basic limited gameplay and features) but is a complete revamp of such games, offering an open world experience but also packing in an astonishing amount of gameplay features and mechanics, not to mention how good it looks.</p>
		   				</div>
		   			</div>
		   		</div>
		   	</li>
		  	</ul>
	  	</div>
	</aside>

	
	<div id="fh5co-content">
		<div class="video fh5co-video" style="background-image: url(images/img_bg_1.jpg);">
		<iframe width="100%" height="315" src="https://www.youtube.com/embed/WjSIdLdp_d8" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
		</div>
		<div class="choose animate-box fadeInUp animated-fast">
			<div class="fh5co-heading">
				<h2 style="color: white !important;">Souless</h2>
				<p>Heres is a demo video of the game, this is actual gameplay footage. <br><br>(Updated on 11/11/18) </p>
			</div>
		</div>
	</div>


	<div id="fh5co-started" style="background-image:url(images/img_bg_2.jpg);">
		<div class="overlay"></div>
		<div class="container">
			<div class="row animate-box">
				<div class="col-md-8 col-md-offset-2 text-center fh5co-heading">
					<h2>Want To Participate In The Public Beta?</h2>
					<p>Download the game and report bugs and feature requests back to the <a href="https://www.reddit.com/r/soulless_rogue/">subreddit</a>.</p>
					<p><a id="dl" href="http://www.soulless.co.za/game_files/game.zip" class="btn btn-default btn-lg">Download (Windows)</a></p>
					<p id="dlTxt"><a href="http://www.soulless.co.za/game_files/game.zip">Download Anyways</a></p>
				</div>
			</div>
		</div>
	</div>

	
	<footer id="fh5co-footer" role="contentinfo">
		

			<div class="row copyright">
				<div class="col-md-12 text-center">
					<p>
						<small class="block">&copy; 2018 bogz. All Rights Reserved.</small> 
					</p>
					<p>
						<ul class="fh5co-social-icons">
							<li><a href="https://github.com//"><i class="icon-github"></i></a></li>
						</ul>
					</p>
				</div>
			</div>

		</div>
	</footer>
	</div>

	<div class="gototop js-top">
		<a href="#" class="js-gotop"><i class="icon-arrow-up"></i></a>
	</div>
	
	<!-- jQuery -->
	<script src="js/jquery.min.js"></script>
	<!-- jQuery Easing -->
	<script src="js/jquery.easing.1.3.js"></script>
	<!-- Bootstrap -->
	<script src="js/bootstrap.min.js"></script>
	<!-- Waypoints -->
	<script src="js/jquery.waypoints.min.js"></script>
	<!-- Flexslider -->
	<script src="js/jquery.flexslider-min.js"></script>
	<!-- Magnific Popup -->
	<script src="js/jquery.magnific-popup.min.js"></script>
	<script src="js/magnific-popup-options.js"></script>
	<!-- Main -->
	<script src="js/main.js"></script>
	<script type="text/javascript">


		if (jscd.os != "Windows")
		{
			$("a#dl").removeAttr('href');
			$("a#dl").text("Your OS is not supported.");
		}
		else 
		{
			$("a#dlTxt").removeAttr('href');
			$("p#dlTxt").html("<i>We detected that your OS is <strong>" + jscd.os + "</strong>, which is supported.</i>");
		}
	</script>
	</body>
</html>
