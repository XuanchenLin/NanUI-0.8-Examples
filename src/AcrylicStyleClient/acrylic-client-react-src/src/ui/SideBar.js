import { useAppContext } from "../AppContext";

const SideBar = () => {
  const { state } = useAppContext();
  const { currentPage } = state;

  return (
    <aside className={`side-bar ${currentPage}`}>
      <div className="intro">
        {/* <span>侧边栏</span>
        <span>透明/可拖动</span> */}
        <span>SideBar</span>
      </div>
    </aside>
  );
};

export default SideBar;
