const URI = "https://localhost:7148/api/textsearch?";

export async function textSearchApi(textSearchObject) {

    const resp = await fetch(`${URI}${objectToSearchParams(textSearchObject)}`);
    const data = await resp.json();

    if (!resp.ok) {
        const { errors } = data;
        return errors;
    }
    return data;
}

function objectToSearchParams(textSearchObject) {
    return new URLSearchParams([...Object.entries(textSearchObject)]).toString();
}