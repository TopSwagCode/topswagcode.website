<script>
	import Content from "../Content.svelte";
	import TagsList from "../TagsList.svelte";
	
	var skills = "C#, ASP.NET, Dotnet Core, Docker, RabbitMQ, SQS, Razor, Entity Framework, Dapper, SQL, Java, JavaScript, TypeScript, CSS, Eclipse, Visual Studio, VictoriaMetrics, OpenTelemetry, Jira, Azure AZ 900 Certified, AWS";
	var buzzWords = "Scrum, eXtreme Programming, Agile, Test Driven Development, CI CD, lean managment / development, Testing (Pairwise / Exploratory / tours), SOA, Microservices";

	function PrintPdf() {
		var printContent = document.getElementById("print");

		var printWindow = window.open('', 'WinPrint', 'left=0,top=0,width=800,height=900,toolbar=0,scrollbars=0,status=0');
		printWindow.document.write(printContent.innerHTML);
		cloneLinksAndStyles(window, printWindow);
		printWindow.document.close();
		printWindow.focus();
		printWindow.print();
		printWindow.close();
	}

	// This could be made into a simple print package?
	function cloneLinksAndStyles (win, newWin) {
		const newHead = newWin.document.head;

		const links = Array.from(win.document.getElementsByTagName("LINK"));
		links.forEach(link => {
			let newLink = newWin.document.createElement('link');
			newLink.rel = 'stylesheet';
			var linkText = link.href.replace("cv./", "");
			console.log("link text");
			console.log(linkText);
			newLink.href = linkText;
			newHead.appendChild(newLink);
		});

		const styles = Array.from(win.document.getElementsByTagName('STYLE'));
		styles.forEach(style => {
			let newStyle = newWin.document.createElement('style');
			newStyle.innerHTML = style.innerHTML;
			newHead.appendChild(newStyle);
		});
	}
</script>

<svelte:head>
	<title>Curriculum Vitae</title>
	<meta name="description" content="Curriculum Vitae for Joshua Jesper Krægpøth Ryder" />
</svelte:head>

<div id="print">
<Content headline="Curriculum Vitae">
	<div class="text-sm font-medium">
		<p class="m-0.5"><b>Name:</b> Joshua Jesper Krægpøth Ryder</p>
		<p class="m-0.5"><b>Adress:</b> Ahornvej 3.</p>
		<p class="m-0.5"><b>ZipCode:</b> 8751</p>
		<p class="m-0.5"><b>City:</b> Gedved</p>
		<p class="m-0.5"><b>Tel.:</b> 0045 20 49 08 59</p>
		<p class="m-0.5"><b>E-mail:</b> josh@topswagcode.com</p>
		<p class="m-0.5"><b>Born:</b> 17/02/1987</p>
	</div>

	<ul class="text-sm font-medium border rounded-lg my-4">
		<li class="bg-neutral text-neutral-content w-full px-4 py-2 border-b rounded-t-lg">Work experience</li>
		<li class="w-full px-4 py-2 border-b">2023 - Now: iPaper</li>
		<li class="w-full px-4 py-2 border-b">2021 - 2023: Mærsk</li>
		<li class="w-full px-4 py-2 border-b">2019 - 2022: Brølstærk</li>
		<li class="w-full px-4 py-2 border-b">2016 - 2019: First Agenda</li>
		<li class="w-full px-4 py-2 border-b">2016: Wallmob</li>
		<li class="w-full px-4 py-2 border-b">2014-2016: Stibo</li>
		<li class="w-full px-4 py-2 border-b">2014 : Ebay / bilinfo.net (Internship + Bachelor assignment.)</li>
		<li class="w-full px-4 py-2 rounded-b-lg">2011-2013 : Novicell (Startet as intern and had my AP assignment here and afterwards hired fulltime)</li>
	</ul>
	
	<ul class="text-sm font-medium border rounded-lg my-4">
		<li class="bg-neutral text-neutral-content w-full px-4 py-2 border-b rounded-t-lg">School experience</li>
		<li class="w-full px-4 py-2 border-b">2015-2016 : Master IT-Vest Module - Scalable Web Developement, P2P Networking and Docker</li>
		<li class="w-full px-4 py-2 border-b">2012-2014 : Bachelor in Software development at Business Academy Aarhus</li>
		<li class="w-full px-4 py-2 border-b">2008-2011 : AP in Software development at Business Academy Aarhus</li>
		<li class="w-full px-4 py-2 border-b">2006-2007 : Computer Science at Århus university (Not completd)</li>
		<li class="w-full px-4 py-2 border-b">2003-2006 : Business College. http://www.eucnordvest.dk</li>
	</ul>

	<ul class="text-sm font-medium border rounded-lg my-4">
		<li class="bg-neutral text-neutral-content w-full px-4 py-2 border-b rounded-t-lg">Results</li>
		<li class="w-full px-4 py-2 border-b">Reducing page load time from minutes to few seconds and at the same time reducing response size from 10mb to 90kb while keeping all the same data. This was achieved by going from SQL database to timeseries database and going from a flat response model to tree model removing duplicate data.</li>
		<li class="w-full px-4 py-2 border-b">Creating a new Microservice overnight in spare time, to implement wished feature that users had asked for, but had not been prioritized. Showing that going over to microservices let us work more agile and create new services without interfering with prior code base. All code and deployment setup complete during one night of coding.</li>
		<li class="w-full px-4 py-2 border-b">Getting Stibo to change to jMeter saving them alot of money and making performance more easy to approach, by persiting in talking about it and making demo’s of it in my spare time.</li>
		<li class="w-full px-4 py-2 border-b">Development of Kosan Gas webshop, and associated business logic matrix.</li>
		<li class="w-full px-4 py-2 rounded-b-lg">Development of new checkout flow for Punkt1.dk. The old checkout flow had to many step and many customers didn’t complete their order. The project was deployed in under a week and result could be seen instantly.</li>
	</ul>

	<ul class="text-sm font-medium border rounded-lg my-4">
		<li class="bg-neutral text-neutral-content w-full px-4 py-2 border-b rounded-t-lg">Skills</li>
		<li class="w-full px-4 py-2 rounded-b-lg"><TagsList tags={skills} /></li>
	</ul>

	<ul class="text-sm font-medium border rounded-lg my-4">
		<li class="bg-neutral text-neutral-content w-full px-4 py-2 border-b rounded-t-lg">Buzz words</li>
		<li class="w-full px-4 py-2 rounded-b-lg"><TagsList tags="{buzzWords}"/></li>
	</ul>

	<ul class="text-sm font-medium border rounded-lg my-4">
		<li class="bg-neutral text-neutral-content w-full px-4 py-2 border-b rounded-t-lg">Extra</li>
		<li class="w-full px-4 py-2 border-b">During school I was paid and received a diploma for being a "Learning Assistant" in an innovations process “Eksperts in teams” at Business Academy Aarhus.</li>
		<li class="w-full px-4 py-2 border-b">2006-2015 I worked as voluteer at Kidney Association’s youth department. During the years my task had grown including going to NNS in Oslo and CEAPIR in Zürich.</li>
		<li class="w-full px-4 py-2 border-b">I speak and write Danish fluently.</li>
		<li class="w-full px-4 py-2 rounded-b-lg">I speak and write English fluently</li>
	</ul>	
</Content>
</div>

<div class='hidden md:block fixed p-10 bottom-10 w-full'>
    <button on:click={() => PrintPdf()} class=' motion-safe:animate-bounce my-8 float-right px-5 py-2 btn btn-accent rounded-full focus:outline-none'>Print</button>
</div>
