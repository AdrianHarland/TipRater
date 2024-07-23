import React from 'react';
import { fetchVideo } from '../../api/videoAPI';
import './Video.css';

type VideoType = { name: string; link: string; views: number; votes: number };

const Video = () => {
	const [videos, setVideos] = React.useState<VideoType[]>([]);
	const [failLoad, setFailLoad] = React.useState(true);
	const fetchData = async () => {
		try {
			const videoResponse = await fetchVideo();
			setVideos(videoResponse);
			setFailLoad(false);
		} catch (error) {
			console.log('error', error);
		}
	};
	React.useEffect(() => {
		fetchData();
	}, []);
	return (
		<div className="content">
			<ul className="video-content">
				{!failLoad
					? videos.map((item, index) => {
							return (
								<ul className="videoData" key={index}>
									<div className="embed">
										{' '}
										<img
											src={`http://i3.ytimg.com/vi/${item.embed}/hqdefault.jpg`}
										/>
										{/* <iframe
											width="315"
											height="560"
											src={`https://www.youtube.com/embed/${item.embed}`}
											title="YouTube video player"
											allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"
										></iframe> */}
									</div>
									<div className="video-info">
										<p>{item.name}</p>
									</div>
								</ul>
							);
						})
					: "It's dead"}
			</ul>
		</div>
	);
};
export default Video;
