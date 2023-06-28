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
	  <div class="form-control">
		<input type="text" placeholder="Search" class="input input-bordered w-24 md:w-auto" />
	  </div>
	  <div class="dropdown dropdown-end">
		<label tabindex="0" class="btn btn-ghost btn-circle avatar">
		  <div class="w-10 rounded-full">
			<img alt="Profile Icon" src="https://topswagcode.com/assets/banner-logo.png" />
		  </div>
		</label>
		<ul tabindex="0" class="mt-3 z-[1] p-2 shadow menu menu-sm dropdown-content bg-base-100 rounded-box w-52">
		  <li>
			<a class="justify-between">
			  Profile
			  <span class="badge">New</span>
			</a>
		  </li>
		  <li><a>Settings</a></li>
		  <li><a>Logout</a></li>
		</ul>
	  </div>
	</div>
  </div>

<style>

</style>
