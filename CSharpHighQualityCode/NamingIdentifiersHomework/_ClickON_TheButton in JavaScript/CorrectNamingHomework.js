function onButtonClick(event, arguments) {
  var myWindow= window,
      browser = myWindow.navigator.appCodeName,
      isMozillaBrowser = (browser == "Mozilla");
  if(isMozillaBrowser) {
    alert("Yes");
  } else {
    alert("No");
  }
}
