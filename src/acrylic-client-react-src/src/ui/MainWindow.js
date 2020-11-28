import MainView from "./MainView";
import SideBar from "./SideBar";
// import { AppContext } from "../AppContext.js";

const MainWidow = () => {
  return (
    <div className="main-window">
      <SideBar></SideBar>
      <MainView></MainView>
    </div>
  );
};

export default MainWidow;
