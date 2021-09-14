function longestSubstring(s) {
    // if length lower than two, no chance of repeat, just return length
    if(s.length < 2) {
        return s.length;
    }

    // create answer variable
    // create two variables for two pointer method
    let answer = 0, i = 0, j = 0;
    // list to hold substring
    let list = [];
    // while both pointers are less than the length of the input string
    while(i < s.length && j < s.length) {
        // if substring doesnt contain current character
        if(!list.includes(s[j])) {
            // push it to substring list
            list.push(s[j]);
            // increment leading pointer
            j++;
            // find max substring length
            answer = Math.max(answer, j - i);
        }
        // if substring does contain current character
        else {
            // remove first character of substring
            list.splice(list.indexOf(s[i]), 1);
            // increment trailing pointer
            i++;
        }    
    }
    // return longest substring length
    return answer;
};