<script>
	import { page } from '$app/stores';
	import { goto } from '$app/navigation';

	const navigate = (link) => {
		goto(link);
	}
</script>

<div class="btm-nav"><!--https://flowbite.com/icons/-->
	<button on:click={() => navigate("/")} class="{$page.url.pathname === '/' ? 'active bg-primary-focus' : undefined} hover:bg-primary">
		<svg class="w-6 h-6 dark:text-white" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 20 20">
			<path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M3 8v10a1 1 0 0 0 1 1h4v-5a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1v5h4a1 1 0 0 0 1-1V8M1 10l9-9 9 9"/>
		  </svg>
	  <span class="btm-nav-label">Home</span>
	</button>
	<button on:click={() => navigate("/about")} class="{$page.url.pathname === '/about' ? 'active bg-primary-focus' : undefined} hover:bg-primary">
		<svg class="w-6 h-6 dark:text-white" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 20 20">
			<path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M10 19a9 9 0 1 0 0-18 9 9 0 0 0 0 18Zm0 0a8.949 8.949 0 0 0 4.951-1.488A3.987 3.987 0 0 0 11 14H9a3.987 3.987 0 0 0-3.951 3.512A8.948 8.948 0 0 0 10 19Zm3-11a3 3 0 1 1-6 0 3 3 0 0 1 6 0Z"/>
		  </svg>
	  <span class="btm-nav-label">About</span>
	</button>
	<button on:click={() => navigate("/weather")} class="{$page.url.pathname === '/weather' ? 'active bg-primary-focus' : undefined} hover:bg-primary">
	  <svg class="w-6 h-6 dark:text-white" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 20 20">
		<path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M10 3V1m0 18v-2M5.05 5.05 3.636 3.636m12.728 12.728L14.95 14.95M3 10H1m18 0h-2M5.05 14.95l-1.414 1.414M16.364 3.636 14.95 5.05M14 10a4 4 0 1 1-8 0 4 4 0 0 1 8 0Z"/>
	  </svg>
	  <span class="btm-nav-label">Weather forecasts</span>
	</button>
	<button on:click={() => navigate("/cv")} class="{$page.url.pathname === '/cv' ? 'active bg-primary-focus' : undefined} hover:bg-primary">
		<svg class="w-6 h-6 dark:text-white" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 18 20">
			<path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M12 2h4a1 1 0 0 1 1 1v15a1 1 0 0 1-1 1H2a1 1 0 0 1-1-1V3a1 1 0 0 1 1-1h4m6 0a1 1 0 0 0-1-1H7a1 1 0 0 0-1 1m6 0v3H6V2M5 5h8m-8 5h8m-8 4h8"/>
		  </svg>
		<span class="btm-nav-label">Curriculum Vitae</span>
	  </button>
</div>

<style>
</style>
