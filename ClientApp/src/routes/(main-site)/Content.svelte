<script>
    export let headline;
</script>

<div class="grid place-items-center p-5">
    <!--<div class="grid p-5">-->
	<div class="max-w-4xl place-items-start px-6 w-full">
        <h1 class="w-full text-4xl my-4">{headline}</h1>
        <slot>
        </slot>
    </div>
</div>

<style>

</style>