import React from "react";
import AppContext from "./AppContext";
import "./App.scss";
import MainWidow from "./ui/MainWindow";

const App = () => {
  return (
    <AppContext>
      <MainWidow></MainWidow>
    </AppContext>
  );
};

export default App;
