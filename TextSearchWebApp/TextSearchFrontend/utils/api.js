const URI = "https://localhost:7148/api/textsearch";

export async function textSearchApi(textSearchObject) {
    const resp = await fetch(`${URI}`, {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(textSearchObject)
    });
    const data = await resp.json();

    if (!resp.ok) {
        const { errors } = data;
        return errors;
    }
    return data;
}