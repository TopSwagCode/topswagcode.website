<script>
	import { onDestroy, onMount } from 'svelte';
	import Content from '../Content.svelte';

	let slideNumber = 0;
	let interval = 0;

	/*
	onMount( async () => {
		interval = setInterval(ChangeSlide, 5000); // Async is workaround for letting Sveltekit know not to start OnMount before page is reached.
  	});

	function ChangeSlide(){
		slideNumber++;
		slideNumber = slideNumber % 3;
		let slide = "#slide"+slideNumber;
		var element = document.getElementById(slide);
		element.click();
	}

	onDestroy(() => {
		clearInterval(interval);
	});
	*/
</script>

<svelte:head>
	<title>About</title>
	<meta name="description" content="About this app" />
</svelte:head>

<Content headline="About">
	<p class="py-2">
		Well never been good at telling about my self. I will try my best :) A few things describing me:
	</p>

	
	<ul class="py-2">
		<li class="p-0.5 px-2">Code enthusiast.</li>
		<li class="p-0.5 px-2">Table top gamer.</li>
		<li class="p-0.5 px-2">Loving boyfriend.</li>
		<li class="p-0.5 px-2">Loving father.</li>
		<li class="p-0.5 px-2">Cat owner.</li>
	</ul>

	<p class="py-2">
	Going more in depth. I love to code. I love to learn and improve. Being that design patterns or new tech. That is why I attend meetups, hackathons and the sorts. This is also kind of the reason why I wanted to take up blogging. Sharing the awesome stuff I found. I have tried a couple of times and failed. Used to much time on “What plugins should I try?”, “What design / Theme do I want?”, “What do I want to blog about?” and so on. When I should simply just have made alot of small blog posts about what I had been looking on that week.
	</p>
	<p class="py-2">
	Over the last few years I have gone from being a online gamer to being a table top gamer with my girlfriend. We bought a house and moved to Gedved and didn’t really know anybody in the area. We decided to start a local table top group. We thought it would be awesome way to learn new people and invite strangers in for board game evenings. So we started a Facebook group and made some comments in different local facebook groups that anyone who wanted to come by and play some games were welcome.
	</p>
	<p class="py-2">
	Today we are me, my Girlfriend, a baby and 2 cats. Here we have a house with plenty of room for us all. Beside board gaming we love to go for long walks. We love to travel and can’t wait to take our baby with us out on adventures. Below you can see a few pictures of us.
	</p>
	

	<div class="grid place-items-center p-5">
		<div class="carousel carousel-end rounded-box content-center">
			<div class="carousel-item">
				<img height="250" width="248.328" src="https://ik.imagekit.io/topswagcode/tr:h-250/inastorm.jpg" alt="Ina and Storm" />
			</div> 
			<div class="carousel-item">
				<img height="250" width="121.656" src="https://ik.imagekit.io/topswagcode/tr:h-250/joshstorm.png" alt="Joshua and Storm" />
			</div> 
			<div class="carousel-item">
				<img height="250" width="333.328" src="https://ik.imagekit.io/topswagcode/tr:h-250/pjevs.jpg" alt="Cat Pjevs" />
			</div>
		</div>
	</div>

	<p class="py-2">
		
	</p>

	<div class="grid place-items-center p-5">
		<div class="max-w-4xl carousel carousel-center max-w-md p-4 space-x-4 bg-neutral rounded-box">
			<div id="slide0" class="carousel-item">
				<img class="rounded-box p-2" height="250" src="https://ik.imagekit.io/topswagcode/tr:h-250/grpc.jpg" alt="GRPC" />
			</div> 
			<div id="slide1" class="carousel-item">
				<img class="rounded-box p-2" height="250" src="https://ik.imagekit.io/topswagcode/tr:h-250/wasm.jpg" alt="WASM" />
			</div> 
			<div id="slide2" class="carousel-item">
				<img class="rounded-box p-2" height="250" src="https://ik.imagekit.io/topswagcode/tr:h-250/security.jpg" alt="Security" />
			</div>
		</div>
		<div class="invisible"><a id="#slide0" href="#slide0">#slide0</a><a id="#slide1"  href="#slide1">#slide1</a><a id="#slide2"  href="#slide2">#slide2</a></div>
	</div>
</Content>

<style>
	img { height: 250px }
</style>