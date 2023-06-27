<script>
    export let data;
	import Content from '../Content.svelte';
</script>

<svelte:head>
	<title>Weather forecasts</title>
	<meta name="description" content="Weather forecasts" />
</svelte:head>

<Content headline="Weather forecasts">
	<div class="w-4xl">
		{#if data.weatherForecasts.length}
		<table class="table-auto">
			<thead>
			  <tr>
				<th>Date</th>
				<th>Temperature C</th>
				<th>Temperature F</th>
				<th>Summary</th>
			  </tr>
			</thead>
			<tbody>
			  {#each data.weatherForecasts as weatherForecast}
			  <tr>
				<td>{weatherForecast.date}</td>
				<td>{weatherForecast.temperatureC}</td>
				<td>{weatherForecast.temperatureF}</td>
				<td>{weatherForecast.summary}</td>
			  </tr>
			  {/each}
			</tbody>
		  </table>
		  {/if}
	</div>
	
</Content>
