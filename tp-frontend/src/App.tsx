// import { useState } from 'react';
import '@mantine/core/styles.css';
import './App.css';
import { Route, Routes } from 'react-router-dom';
import Video from './components/Video/Video';

function App() {
	return (
		<>
			<Routes>
				<Route element={<Video />} path="/video" />
			</Routes>
		</>
	);
}

export default App;
