<script>
    export let data;
	import Content from '../Content.svelte';
</script>

<svelte:head>
	<title>Weather forecasts</title>
	<meta name="description" content="Weather forecasts" />
</svelte:head>

<Content headline="Weather forecasts">
	<div class="text-column">
		<p>
			<button class="btn">Button</button>
			<button class="btn btn-neutral">Neutral</button>
			<button class="btn btn-primary">Button</button>
			<button class="btn btn-secondary">Button</button>
			<button class="btn btn-accent">Button</button>
			<button class="btn btn-ghost">Button</button>
			<button class="btn btn-link">Button</button>
		</p>
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
	
</Content>
