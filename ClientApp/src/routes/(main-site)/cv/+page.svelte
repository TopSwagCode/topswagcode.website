<script>
	import Content from "../Content.svelte";

</script>
<svelte:head>
	<title>CV</title>
	<meta name="description" content="CV" />
</svelte:head>

<Content headline="Curriculum Vitae">
	<p>Name: Joshua Jesper Krægpøth Ryder</p>
	<p>Adress: Ahornvej 3.</p>
	<p>ZipCode: 8751</p>
	<p>City: Gedved</p>
	<p>Tel.: 0045 20 49 08 59</p>
	<p>E-mail: josh@topswagcode.com</p>
	<p>Born: 17/02/1987</p>
		

	<ul class="text-sm font-medium border rounded-lg my-4">
		<li class="bg-neutral text-neutral-content w-full px-4 py-2 border-b rounded-t-lg">Work</li>
		<li class="w-full px-4 py-2 border-b">2019 - Now: Brølstærk</li>
		<li class="w-full px-4 py-2 border-b">2016 - 2019: First Agenda</li>
		<li class="w-full px-4 py-2 border-b">2016: Wallmob</li>
		<li class="w-full px-4 py-2 border-b">2014-2016: Stibo</li>
		<li class="w-full px-4 py-2 border-b">2014 : Ebay / bilinfo.net (Internship + Bachelor assignment.)</li>
		<li class="w-full px-4 py-2 border-b">2011-2013 : Novicell (Startet as intern and had my AP assignment here and afterwards hired fulltime)</li>
		<li class="w-full px-4 py-2 rounded-b-lg">2003-2006 : Fjord Line (Checkin Employee)</li>
	</ul>
	
	<ul class="text-sm font-medium border rounded-lg my-4">
		<li class="bg-neutral text-neutral-content w-full px-4 py-2 border-b rounded-t-lg">School</li>
		<li class="w-full px-4 py-2 border-b">2015-2016 : Master IT-Vest Module - Scalable Web Developement, P2P Networking and Docker</li>
		<li class="w-full px-4 py-2 border-b">2012-2014 : Bachelor in Software development at Business Academy Aarhus</li>
		<li class="w-full px-4 py-2 border-b">2008-2011 : AP in Software development at Business Academy Aarhus</li>
		<li class="w-full px-4 py-2 border-b">2006-2007 : Computer Science at Århus university (Not completd)</li>
		<li class="w-full px-4 py-2 border-b">2003-2006 : Business College. http://www.eucnordvest.dk</li>
		<li class="w-full px-4 py-2 rounded-b-lg">2003 : Primary school. Tingstrup skole Thisted</li>
	</ul>

	<ul class="text-sm font-medium border rounded-lg my-4">
		<li class="bg-neutral text-neutral-content w-full px-4 py-2 border-b rounded-t-lg">Results</li>
		<li class="w-full px-4 py-2 border-b">Reducing page load time from minutes to few seconds and at the same time reducing response size from 10mb to 90kb while keeping all the same data. This was achieved by going from SQL database to timeseries database and going from a flat response model to tree model removing duplicate data.</li>
		<li class="w-full px-4 py-2 border-b">Creating a new Microservice overnight in spare time, to implement wished feature that users had asked for, but had not been prioritized. Showing that going over to microservices let us work more agile and create new services without interfering with prior code base. All code and deployment setup complete during one night of coding.</li>
		<li class="w-full px-4 py-2 border-b">Getting Stibo to change to jMeter saving them alot of money and making performance more easy to approach, by persiting in talking about it and making demo’s of it in my spare time.</li>
		<li class="w-full px-4 py-2 border-b">Development of Kosan Gas webshop, and associated business logic matrix.</li>
		<li class="w-full px-4 py-2 border-b">Development of new checkout flow for Punkt1.dk. The old checkout flow had to many step and many customers didn’t complete their order. The project was deployed in under a week and result could be seen instantly.</li>
		<li class="w-full px-4 py-2 rounded-b-lg">2003 : Primary school. Tingstrup skole Thisted</li>
	</ul>
	
	<h1 id="skills">Skills</h1> <!-- TODO - Make these into tags or something else visually more nice  -->
	<p><span class="indicator-item badge badge-primary">C#</span> <span class="indicator-item badge badge-primary">ASP.NET</span> Dotnet Core, Docker, MSMQ, SQS, Razor, Entity Framework, NHibernate. SQL, Java, HTML5, JavaScript, CSS.
	Eclipse, Visual Studio, Microsoft SQL Server 2005 / 2008, VictoriaMetrics, Microsoft Test Manager, TConfig, CTE XL, Jira, Azure, AWS.</p>
	
	<h1 id="buzz-words">Buzz words</h1>
	<p>Scrum, eXtreme Programming, Agile, Test Driven Development, CI CD, lean managment / development Testing (Pairwise, Exploratory / tours) SOA, MVC
	During school I had the following course: System integration, Large systems / Scalability, Databases, Testing and C family.  <br>
	During school I also got a diploma for being a Learning Assistant in  innovations process “Eksperts in teams” at Business Academy Aarhus.</p>
	
	<h1 id="language-competence">Language competence</h1>
	<p>I speak and write Danish fluently  <br>
	I speak and write English fluently</p>
	
	<h1 id="other">Other</h1>
	<p>2006-2015 I worked as voluteer at Kidney Association’s youth department. During the years my task had grown including going to NNS in Oslo and CEAPIR in Zürich</p>		
</Content>

<!-- TODO - Make a print button for making CV into PDF / Print + Download -->

<button class="btn">Download</button>
<button class="btn btn-neutral">Print</button>
<button class="btn btn-primary">Download</button>
<button class="btn btn-secondary">Print</button>
<button class="btn btn-accent">Download</button>
<button class="btn btn-ghost">Print</button>
<button class="btn btn-link">Download</button>