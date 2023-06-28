<script>
	import Content from '../Content.svelte';
</script>

<svelte:head>
	<title>About</title>
	<meta name="description" content="About this app" />
</svelte:head>

<Content headline="About">
	<p class="p-1">
		Well never been good at telling about my self. I will try my best :) A few things describing me:
	</p>

	<ul>
	<li>Code enthusiast.</li>
	<li>Table top gamer.</li>
	<li>Loving boyfriend.</li>
	<li>Loving father.</li>
	<li>Cat owner.</li>
	</ul>


	<p class="p-1">
	Going more in depth. I love to code. I love to learn and improve. Being that design patterns or new tech. That is why I attend meetups, hackathons and the sorts. This is also kind of the reason why I wanted to take up blogging. Sharing the awesome stuff I found. I have tried a couple of times and failed. Used to much time on “What plugins should I try?”, “What design / Theme do I want?”, “What do I want to blog about?” and so on. When I should simply just have made alot of small blog posts about what I had been looking on that week.
	</p>
	<p class="p-1">
	Over the last few years I have gone from being a online gamer to being a table top gamer with my girlfriend. We bought a house and moved to Gedved and didn’t really know anybody in the area. We decided to start a local table top group. We thought it would be awesome way to learn new people and invite strangers in for board game evenings. So we started a Facebook group and made some comments in different local facebook groups that anyone who wanted to come by and play some games were welcome.
	</p>
	<p class="p-1">
	Today we are me, my Girlfriend, a baby and 2 cats. Here we have a house with plenty of room for us all. Beside board gaming we love to go for long walks. We love to travel and can’t wait to take our baby with us out on adventures. Below you can see a few pictures of us.
	</p>
	

	<div class="grid place-items-center p-5">
		<div class="carousel carousel-end rounded-box content-center">
			<div class="carousel-item">
				<img height="300" src="https://ik.imagekit.io/topswagcode/tr:h-300/inastorm.jpg" alt="Ina and Storm" />
			</div> 
			<div class="carousel-item">
				<img height="300" src="https://ik.imagekit.io/topswagcode/tr:h-300/joshstorm.png" alt="Joshua and Storm" />
			</div> 
			<div class="carousel-item">
				<img height="300" src="https://ik.imagekit.io/topswagcode/tr:h-300/pjevs.jpg" alt="Cat Pjevs" />
			</div>
		</div>
	</div>
</Content>

<style>
	img { height: 250px }
</style>