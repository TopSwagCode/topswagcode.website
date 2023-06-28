<script>
    export let data;
	import Content from '../Content.svelte';
	import { onMount } from 'svelte';

	let weatherForecasts;

	onMount(async () => {
		const res = await fetch(`/api/WeatherForecast/`);
		weatherForecasts = await res.json();
	});
</script>

<svelte:head>
	<title>Weather forecasts</title>
	<meta name="description" content="Weather forecasts" />
</svelte:head>

<Content headline="Weather forecasts">
	
	{#if weatherForecasts?.length}
	<table class="w-full border-collapse border">
		<thead>
			<tr>
			<th class="border bg-accent">Date</th>
			<th class="border bg-accent">°C</th>
			<th class="border bg-accent">°F</th>
			<th class="border bg-accent">Summary</th>
			</tr>
		</thead>
		<tbody>
			{#each weatherForecasts as weatherForecast}
			<tr>
			<td class="border">{weatherForecast.date}</td>
			<td class="border">{weatherForecast.temperatureC}</td>
			<td class="border">{weatherForecast.temperatureF}</td>
			<td class="border">{weatherForecast.summary}</td>
			</tr>
			{/each}
		</tbody>
	</table>
	{:else}
	<span class="loading loading-spinner loading-xs"></span>
	<span class="loading loading-spinner loading-sm"></span>
	<span class="loading loading-spinner loading-md"></span>
	<span class="loading loading-spinner loading-lg"></span>
	<span class="loading loading-spinner loading-md"></span>
	<span class="loading loading-spinner loading-sm"></span>
	<span class="loading loading-spinner loading-xs"></span>
	{/if}
</Content>