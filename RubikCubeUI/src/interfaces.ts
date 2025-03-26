export type FaceKey = "F" | "R" | "U" | "B" | "L" | "D";
export const faceKeys: FaceKey[] = ["F", "R", "U", "B", "L", "D"];
export type ReverseFaceKey = `${FaceKey}'`;
export const reverseMoveMap: Record<FaceKey, ReverseFaceKey> = {
    F: "F'",
    R: "R'",
    U: "U'",
    B: "B'",
    L: "L'",
    D: "D'"
  };


export const faceColors: Record<FaceKey, string> = {
    U: "#ffffff", // white
    D: "#ffff00", // yellow
    F: "#00ff00", // green
    B: "#1c5ffe", // light blue
    L: "#ff8000", // orange
    R: "#ff0000", // red
};


export interface Sticker {
    x:number,
    y:number
    color: string;
}

export interface Cube2DProps {
    stickers: Sticker[];
}

export const faceButtonClass = (face: FaceKey) => {
    const colors: Record<FaceKey, string> = {
        U: "bg-white text-black border border-gray-300",
        D: "bg-yellow-300 text-black",
        F: "bg-green-500 text-white",
        B: "bg-blue-600 text-white",
        L: "bg-orange-500 text-white",
        R: "bg-red-500 text-white"
    };

    return `px-4 py-2 rounded hover:opacity-80 transition-colors ${colors[face]}`;
};
