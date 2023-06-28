<script>
    export let data;
	import Content from '../Content.svelte';
</script>

<svelte:head>
	<title>Weather forecasts</title>
	<meta name="description" content="Weather forecasts" />
</svelte:head>

<Content headline="Weather forecasts">
	
	{#if data.weatherForecasts.length}
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
			{#each data.weatherForecasts as weatherForecast}
			<tr>
			<td class="border">{weatherForecast.date}</td>
			<td class="border">{weatherForecast.temperatureC}</td>
			<td class="border">{weatherForecast.temperatureF}</td>
			<td class="border">{weatherForecast.summary}</td>
			</tr>
			{/each}
		</tbody>
	</table>
	{/if}
	
	
</Content>
