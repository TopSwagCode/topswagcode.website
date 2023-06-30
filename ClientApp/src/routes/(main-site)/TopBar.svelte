<script>
	import { page } from '$app/stores';
	import logo from '$lib/images/svelte-logo.svg';
	import github from '$lib/images/github.svg';
	import { goto } from '$app/navigation';
	
	const handleClick = (link) => {
		goto(link);
	}
	
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
			<img alt="Profile Icon" src="https://ik.imagekit.io/topswagcode/tr:w-30,h-30/banner-logo.png?updatedAt=1687973066635" />
		  </div>
		</label>
		<!-- svelte-ignore a11y-no-noninteractive-tabindex -->
		<ul tabindex="0" class="mt-3 z-[1] p-2 shadow menu menu-sm dropdown-content bg-base-100 rounded-box w-52">
		  <li>
			<a href="/" class="justify-between">
			  Profile
			  <span class="badge">New</span>
			</a>
		  </li>
		  <li><a href="/" >Settings</a></li>
		  <li><a href="/" >Logout</a></li>
		</ul>
	  </div>
	</div>
  </div>

<style>

</style>
