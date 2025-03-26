import React from "react";
import { Cube2DProps, Sticker } from "../interfaces";

// Kolory przypisane do liter
const faceColors: Record<string, string> = {
    W: "#ffffff", // white
    Y: "#ffff00", // yellow
    G: "#00ff00", // green
    B: "#1c5ffe", // blue
    O: "#ff8000", // orange
    R: "#ff0000", // red
};

export const createGridFromStickers = (stickers: Sticker[]): string[][] => {
   
    const grid: string[][] = Array(9).fill(0).map(() => Array(12).fill(''));
  
    for (const { x, y, color } of stickers) {     
        grid[y][x] = color;
    }
  
    return grid;
  };

const Cube2D: React.FC<Cube2DProps> = ({stickers}) => {

    const grid = createGridFromStickers(stickers!);

    return (
        <div className="grid" style={{ gridTemplateColumns: `repeat(12, 2rem)` }}>
            {grid?.flatMap((row, y) =>
                row.map((color, x) =>
                    color ? (
                        <div
                            key={`${x}-${y}`}
                            className="w-8 h-8 border border-black"
                            style={{ backgroundColor: faceColors[color] || "#ccc" }}
                        >
                            {/* {x},{y} */}
                        </div>
                    ) : (
                        <div key={`${x}-${y}`} className="w-8 h-8" />
                    )
                )
            )}
        </div>
    );
};

export default Cube2D;
