import { useState } from "react";
import { faceButtonClass, FaceKey } from "../interfaces";

type FacesProps = {
    faceKeys: FaceKey[]
    handleSendMove: (facekey: FaceKey) => void
    handleReverseMove: (facekey: FaceKey) => void
    handleResetCube: () => {}
    handleSendMoves: (faceKeys: string) => void
}

const Faces = ({ faceKeys, handleSendMove, handleReverseMove, handleResetCube, handleSendMoves }: FacesProps) => {
    const regex = /^([FRUBLD]('?))(,([FRUBLD]('?)))*$/;
    const [moveInput, setMoveInput] = useState('');
    const [isValid, setIsValid] = useState(true);
    const [disabled,setDisabled] = useState(true);

    const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
        const value = e.target.value.toUpperCase();
        const trimmed = value.trim();
        const isValid = regex.test(trimmed);
        
        setIsValid(isValid);
        setDisabled(!isValid);
        setMoveInput(value);
    };

    const handleSendMultipleMoves = () => {
        handleSendMoves(moveInput);
    }

    return (
        <div className="mt-8 bg-white p-6 rounded-lg shadow-md">
            <h2 className="text-lg font-semibold mb-4">Rotate Faces</h2>
            <div className="grid grid-cols-6 gap-3 mb-6">
                {faceKeys.map(face => (
                    <button
                        key={face}
                        className={faceButtonClass(face)}
                        onClick={() => handleSendMove(face)}
                    >
                        {face}
                    </button>
                ))}
            </div>
            <div className="grid grid-cols-6 gap-3 mb-6">
                {faceKeys.map(face => (
                    <button
                        key={face}
                        className={faceButtonClass(face)}
                        onClick={() => handleReverseMove(face)}
                    >
                        {face}'
                    </button>
                ))}
            </div>

            <div className="flex justify-center mb-5">
                <input
                    value={moveInput}
                    onChange={handleChange}
                    className={`px-3 py-2 border rounded-md w-64 outline-none ring-1 
                                 ${isValid ? "border-green-500 ring-green-300 focus:ring-green-400" : "border-red-500 ring-red-300 focus:ring-red-400"}`}
                />

                <button
                    disabled={disabled}
                    className={`px-4 py-2 bg-gray-200 text-gray-800 rounded hover:bg-gray-300 transition-colors ${
                        disabled
                          ? "bg-gray-300 text-gray-500 cursor-not-allowed"
                          : "bg-gray-200 text-gray-800 hover:bg-gray-300"
                      }`}
            
                    onClick={() => handleSendMultipleMoves()}
                >
                    Send Moves
                </button>
            </div>

            <div className="flex justify-center">
                <button
                    className="px-4 py-2 bg-gray-200 text-gray-800 rounded hover:bg-gray-300 transition-colors"
                    onClick={() => handleResetCube()}
                >
                    Reset Cube
                </button>
            </div>
        </div>
    );
}

export default Faces;