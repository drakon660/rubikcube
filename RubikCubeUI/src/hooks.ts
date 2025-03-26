import { useState } from "react";
import axios from "axios";
import { Cube2DProps, Sticker } from "./interfaces";

const API_BASE = import.meta.env.VITE_API_BASE_URL;

export const useCubeApi = () => {
  const [cube, setCube] = useState<Cube2DProps>();

  const fetchInitialCube = async () => {
    const res = await axios.get<Cube2DProps>(API_BASE);
    setCube(res.data);
  };

  const sendMove = async (move: string, stickers:Sticker[]) => {
    const res = await axios.post<Cube2DProps>(`${API_BASE}`, {
        move: move,
        stickers:stickers
    }, {
      headers: { "Content-Type": "application/json" }
    });
    setCube(res.data);
  };

  return { cube, fetchInitialCube, sendMove };
};
