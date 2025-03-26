// See https://aka.ms/new-console-template for more information

using RubikCube;

//var cube = new RubiksCube();

//Console.WriteLine("Początkowy stan:");
//cube.PrintCube();
//cube.ApplyMove(RubikCubeMove.F);

//Console.WriteLine("F before:");

//cube.ApplyMoves(Move.B, Move.L);

//cube.PrintFlatCube();
// cube.ApplyMove(RubikCubeMove.FInverse);
// cube.ApplyMove(RubikCubeMove.RInverse);
// cube.ApplyMove(RubikCubeMove.UInverse);
// cube.ApplyMove(RubikCubeMove.BInverse);
// cube.ApplyMove(RubikCubeMove.LInverse);
// cube.ApplyMove(RubikCubeMove.DInverse);
//cube.ApplyMove(Move.B);
//cube.PrintCube();
//Console.WriteLine("===================================");
//cube.ApplyMove(Move.L);
//cube.ApplyMove(Move.D);
//cube.PrintCube();
var cube = new RubiksCube();
//cube.ApplyMoves("F", "R", "U", "B", "L");
cube.Print();
cube.ApplyFMove(); 

//cube.ApplyLInverseMove();
cube.Print();
//cube.ApplyBInverseMove();
//cube.Print();
Console.WriteLine("===================================");
//cube.ApplyDMove();
//cube.Print();
//Console.WriteLine("\nPo ruchu D:");
//cube.PrintFace(18);

//cube.PrintCube();
