
interface IBrewery {
    name: string;
    location: string;
}

(async () => {
    const breweries = $('#breweries')[0];

    const result : IBrewery[] = await $.getJSON('http://localhost:8080/api/breweries');
    let html: string = "";
    for(let item of result) {
        html += `<li>${item.name}</li>`;
    }

    breweries.innerHTML = html;
})();

