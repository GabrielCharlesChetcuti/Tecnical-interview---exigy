# Tecnical-interview---exigy

The file found contains the code required to solve the problem 'Clock Patience'.

It is found inside the file 'Program.cs'

One problem I ran into was the fact that the sample output did not match the output provided by my code.

A potential reason for this is the fact that there could be discrepancy between the expected game ending and the one I understood and implemented.

The rule says: "The game ends when the pile indicated by the current card has no face down cards in it."

My code interprets this rule to mean that the game should end when there is an attempt to draw from a pile that has no face-down cards left.

However, the expected output of 44,KD seems to suggest a different understanding of the game ending. 

If the game should end as soon as the pile indicated by the current card is empty, then it would explain the difference in final output.

Just wanted to point this out.
