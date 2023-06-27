<script>
	import BottomNavigation from './BottomNavigation.svelte';
	import TopBar from './TopBar.svelte';
	import './styles.css';
	// Import our global CSS
	import "$lib/global.css";
	
	export const prerender = true;
</script>

<div class="app">


	<TopBar />

	
	<main>
		<slot />
	</main>

	<div class="navbar bg-base-100">
		
	</div>

	<BottomNavigation />

</div>

<style>

</style>
