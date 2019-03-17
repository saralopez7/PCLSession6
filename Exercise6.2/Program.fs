
let rec pclCollect (ls:'a list) = 
    let ls = List.rev ls

    let rec appendToFinal (sub_list:'a list) previous (final_list: 'a list list) (ls:char list) =
       match ls with
       | [] -> (sub_list :: final_list)
       | hd :: tail -> if hd = previous then appendToFinal (hd :: sub_list) hd final_list tail
                       else appendToFinal ([hd]) hd (sub_list :: final_list) tail

    appendToFinal [] ls.[0] [] ls
    
pclCollect ['p'; 'p'; 's'; 'c'; 'a'; 'l';'a';'p'; 'c';'l';'y'];;       