<script>
	import Tag from "./Tag.svelte";

    export let tags;

    let tagsArray = tags.split(",");
    // split on comma and foreach over tags
</script>

{#each tagsArray as tagText}
    <Tag text={tagText} />
{/each}