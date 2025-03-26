import { useEffect } from "react";
import { useCubeApi } from "../hooks";
import { FaceKey, faceKeys, reverseMoveMap } from "../interfaces";
import Cube2D from "./Cube2D";
import Faces from "./Faces";

const RubikCube = () => {
    const { cube, fetchInitialCube, sendMove } = useCubeApi();

    useEffect(() => {
        fetchInitialCube();
    }, []);

   
    const handleSendMove = (move: FaceKey) => {
        sendMove(move, cube!.stickers);
    }

    const handleReverseMove = (move: FaceKey) => {
        sendMove(reverseMoveMap[move], cube!.stickers);
    }

    const handleSendMoves = (moves:string) => {
      sendMove(moves,cube!.stickers);
    };

    return (
        <div className="min-h-screen flex flex-col items-center justify-center bg-gray-100 p-8">
            <h1 className="text-2xl font-bold mb-6">Rubik's Cube Simulator</h1>
            {
                cube && <Cube2D stickers={cube!.stickers} />
            }
           <Faces faceKeys={faceKeys} handleResetCube={fetchInitialCube} handleReverseMove={handleReverseMove} handleSendMove={handleSendMove} handleSendMoves={handleSendMoves}></Faces>
        </div>
    );
}

export default RubikCube;