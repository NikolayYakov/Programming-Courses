function editElement(elementRef,match,replacer) {
  const text = elementRef.textContent;
  const matcher = new RegExp(match,'g');
  const edited = text.replace(matcher,replacer);
  elementRef.textContent = edited;
    
}