function loadRepos() {
	 let username = document.getElementById('username');
	 let url = `https://api.github.com/users/${username.value}/repos`;
	 let ul = document.getElementById('repos');
	 while(ul.childElementCount>0){
		 ul.removeChild(ul.children[0]);
	 }
	 fetch(url)
	 .then(res=>{
		 if(res.ok){
			 return res.json();

		 }else{
			 console.log(res);
			 let li = document.createElement('li');
			 li.textContent = res.status;
			 ul.appendChild(li);
		 }
	 })
	 .then(text=>{
	    for (const element of text) {
			let li = document.createElement('li');
			let a = document.createElement('a');
			a.setAttribute('href',element.html_url);
			a.textContent = element.full_name;
			li.appendChild(a);
			ul.appendChild(li);
		}
	 })
	 .catch(ex => {
		console.log(ex.message);
	 })

}