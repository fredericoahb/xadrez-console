![GitHub last commit](https://img.shields.io/github/last-commit/fredericoahb/xadrez-console)
![GitHub language count](https://img.shields.io/github/languages/count/fredericoahb/xadrez-console)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/fredericoahb/xadrez-console)
![GitHub repo size](https://img.shields.io/github/repo-size/fredericoahb/xadrez-console)



# Chess game

Application written in C# with good software engineering practices using Multitier architecture.

The chess system is divided into three tiers, where each tier has a very specific responsibility.

Board tier - This tier will contain the basic elements of a board: piece, position, color of the piece. In this tier, there is no game intelligence, simply the basic operation of a board. Remove and place the pieces.

Chess tier - Intelligence tier where the rules of the chess game are implemented. One piece moves at a time; the pieces movement rules; the game mechanical rules 

Application tier - console mode application that will consume the other two tiers, interact with the user and present the game.

## Chess System Design

![Design 1](https://github.com/fredericoahb/chess-system-java/blob/master/chess-system-design.png)
