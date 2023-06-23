<script>
    export let data;
	console.log(data.weatherForecasts);
</script>

<svelte:head>
	<title>Weather forecasts</title>
	<meta name="description" content="Weather forecasts" />
</svelte:head>

<div class="text-column">
	<h1></h1>
	<caption class="caption-top">
		Weather forecasts
	  </caption>
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
