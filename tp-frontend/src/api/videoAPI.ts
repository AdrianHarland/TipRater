export const fetchVideo = () => {
	return fetch(`http://localhost:5243/api/video/`)
		.then((response) => response.json())
		.catch((error) => console.log("It's Dead dude", error));
};
