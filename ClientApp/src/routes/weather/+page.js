import { dev } from '$app/environment';

//export const prerender = true;

export const load = async ({ fetch }) => {
    const res = await fetch(`/api/WeatherForecast/`);

    if(res.ok){
        const weatherForecasts = await res.json();
        return { weatherForecasts };
    }

    const { message } = await res.json();

    return {
        error: new Error(message)
    };
}