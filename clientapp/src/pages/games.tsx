import React from 'react';
import { GamesProps } from '@/interfaces/GamesProps';
import GameTable from '@/components/GameTable';

const Games = (props: GamesProps) => {
    const {
        gameList 
    } = props;

    return (
        <GameTable 
            gameList={gameList}
        />
    );
}

export const getStaticProps = async () => {
  return {
    props: {
      gameList: ['Half Life', 'Counter-Strike', 'Doom', 'Quake', 'Doom II', 'Doom 3', 'Doom Eternal'],
    },
  };
};

export default Games;