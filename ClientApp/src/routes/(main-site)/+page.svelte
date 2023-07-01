<script>
	import welcome from '$lib/images/svelte-welcome.webp';
	import welcome_fallback from '$lib/images/svelte-welcome.png';
</script>

<svelte:head>
	<title>Home</title>
	<meta name="description" content="Svelte demo app" />
</svelte:head>

<section>
	<div class="hero min-h-screen bg-base-200">
		<div class="hero-content text-center">
		  <div class="max-w-md">
			<h1 class="text-5xl font-bold">Hello there</h1>
			<p class="py-6">Welcome to topswagcode new website. Felt like it was time to move away from Jekyll and update the entire platform to also include API as part of the code base.</p>
			<p class="py-6">The new site is built with Dotnet 7 API with static SPA hosted in static files. The SPA framework choosen is Sveltekit.</p>
			<a href="/about"><button class="btn btn-primary">Read more about me</button></a>
		  </div>
		</div>
	  </div>
</section>

<style>

</style>
