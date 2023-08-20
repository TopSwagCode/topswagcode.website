<script>
	import { page } from '$app/stores';
	import logo from '$lib/images/svelte-logo.svg';
	import github from '$lib/images/github.svg';
	import { goto } from '$app/navigation';
	import { onMount } from 'svelte';
	
	const handleClick = (link) => {
		goto(link);
	}

	let url = "https://topswagcode.com/assets/favicon.png";
	let name = "TopSwagCode"

	onMount(async () =>{

		url="/api/identicon?name="+name+"&size=30";
	});
	
</script>



<div class="navbar bg-neutral text-neutral-content">
	<div class="flex-1">
	  <a href="/" class="btn btn-ghost normal-case text-xl">TopSwagCode</a>
	</div>
	<div class="flex-none gap-2">
	  <div class="dropdown dropdown-end">
		<!-- I know these problems. But it's built into DaisyUI. And it states it's a workaround for Safari browsers -->
		<!-- svelte-ignore a11y-positive-tabindex -->
		<!-- svelte-ignore a11y-no-noninteractive-tabindex -->
		<!-- svelte-ignore a11y-label-has-associated-control -->
		<label tabindex="1" class="btn btn-ghost btn-circle avatar">
		  <div class="w-10 rounded-full">
			<img alt="Profile Icon" src="{url}" />
		  </div>
		</label>
		<!-- svelte-ignore a11y-no-noninteractive-tabindex -->
		<ul tabindex="0" class="mt-3 z-[1] p-2 shadow menu menu-sm dropdown-content rounded-box w-52">
		  <li>
			<a href="/" class="text-primary font-bold justify-between">
			  IdentIcon
			  <span class="badge">New</span>
			</a>
		  </li>
		  <li><input bind:value="{name}" /></li>
		  <li><a href="#" class="text-primary font-bold" >Change icon ☝️</a></li>
		</ul>
	  </div>
	</div>
  </div>

<style>

</style>
