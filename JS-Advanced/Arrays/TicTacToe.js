function solve(input){
    let board = [[false,false,false],
                 [false,false,false],
                 [false,false,false]];
    let turn = 1;
    while(input.length>0){
        let cordinates = input.shift().split(' ');
        let row = cordinates[0];
        let col = cordinates[1];
        let isWon = false;
        let element = ''
        if(board[row][col]==false){
            if(turn%2!=0){
                board[row][col] = 'X';
                isWon = checkWin(row,col,'X',board);
                element = 'X';


            }
            else{
                board[row][col] = 'O';
                isWon = checkWin(row,col,'O',board);
                element = 'O';


            }
            turn++;
        }
        else{
            console.log('This place is already taken. Please choose another!');
            


        }
        if(isWon == true){
            console.log(`Player ${element} wins!`);
            for(let i = 0;i<3;i++){
                 
                console.log(board[i].join('\t'))
            }
            break;
        }
        let isEnd = true;
        for(let i = 0;i<3;i++){
            for(let j = 0;j<3;j++){
                if(board[i][j]==false){
                    isEnd = false;
                }
            }
        }
        if(isEnd == true){
            console.log('The game ended! Nobody wins :(');
            for(let i = 0;i<3;i++){
                 
                console.log(board[i].join('\t'))
            }
            break;
        }
        

    }
    function checkWin(row,col,element,board){
        if(board[row][0]==element&&board[row][1]==element&&board[row][2]==element){
            return true;
        }
        else if(board[0][col]==element&&board[1][col]==element&&board[2][col]==element){
            return true;
        }
        else if(board[1][1]==element&&board[0][0]==element&&board[2][2]==element){
            return true;
        }
        else if(board[1][1]==element&&board[0][2]==element&&board[2][0]==element){
            return true;
        }
        else{
            return false;
        }
    }
}
solve("")