<script>
	import { page } from '$app/stores';
	import { goto } from '$app/navigation';

	const navigate = (link) => {
		goto(link);
	}
</script>

<div class="btm-nav"><!--https://flowbite.com/icons/-->
	<button on:click={() => navigate("/")} class="{$page.url.pathname === '/' ? 'active bg-primary-focus' : undefined} hover:bg-primary">
		<div class="text-3xl">🏠</div>
	  	<span class="btm-nav-label">Home</span>
	</button>
	<button on:click={() => navigate("/about")} class="{$page.url.pathname === '/about' ? 'active bg-primary-focus' : undefined} hover:bg-primary">
		<div class="text-3xl">🧑‍💻</div>
	  	<span class="btm-nav-label">About</span>
	</button>
	<button on:click={() => navigate("/weather")} class="{$page.url.pathname === '/weather' ? 'active bg-primary-focus' : undefined} hover:bg-primary">
		<div class="text-3xl">⛅</div>
	  	<span class="btm-nav-label">Weather forecasts</span>
	</button>
	<button on:click={() => navigate("/cv")} class="{$page.url.pathname === '/cv' ? 'active bg-primary-focus' : undefined} hover:bg-primary">
		<div class="text-3xl">💾</div>
		<span class="btm-nav-label">Curriculum Vitae</span>
	</button>
	<button on:click={() => navigate("/boxboxbox")} class="{$page.url.pathname === '/boxboxbox' ? 'active bg-primary-focus' : undefined} hover:bg-primary">
		<div class="text-3xl">🎮</div>
		<span class="btm-nav-label">BoxBoxBox</span>
	</button>
</div>

<style>
</style>
