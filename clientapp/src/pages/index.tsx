import React from 'react';

const Index = () => {
    const handleClick = () => {
        window.location.href = '/games';
    };

    return (
        <div>
        <h1>This is the homepage</h1>
        <button onClick={handleClick}>Games</button>
        </div>
    );
}

export default Index;