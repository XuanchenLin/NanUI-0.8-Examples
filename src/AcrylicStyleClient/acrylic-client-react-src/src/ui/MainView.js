import React from "react";
import { useAppContext } from "../AppContext";
import { ReactComponent as MinimizeIcon } from "./minimize.svg";
import { ReactComponent as CloseIcon } from "./close.svg";

const MainView = (props) => {
  const { state } = useAppContext();
  const { currentPage } = state;

  return (
    <main className="main-view">
      <div className="app-bar">
        <span>Hello I'm a Formium using WinFormium from NanUI</span>
        <div className="sys-commands">
          <div className="sys-command minimize-box" formium-command="minimize">
            <MinimizeIcon />
          </div>
          <div className="sys-command close-box" formium-command="close">
            <CloseIcon />
          </div>
        </div>
      </div>
      <div className={`view-container ${currentPage}`}>
        <div className="view-context">
          <div className="content">
            <p>
              Hello, World! I can use all front-end technologies such as
              HTML/CSS/JavaScript and frameworks like React/Vue/Angluar/Blazor.{" "}
              <strong>It's easy to use, to design, to create.</strong>
            </p>

            <h5>Controls from Bootstrap 4</h5>
            <form className="forms">
              <div className="form-group">
                <label>Email address</label>
                <input
                  type="email"
                  className="form-control"
                  id="exampleInputEmail1"
                  aria-describedby="emailHelp"
                />
                <small id="emailHelp" className="form-text text-muted">
                  We'll never share your email with anyone else.
                </small>
              </div>
              <div className="form-group">
                <label>Password</label>
                <input
                  type="password"
                  className="form-control"
                  id="exampleInputPassword1"
                />
              </div>
              <div className="form-group form-check">
                <input
                  type="checkbox"
                  className="form-check-input"
                  id="exampleCheck1"
                />
                <label className="form-check-label">Check me out</label>
              </div>
              <button type="submit" className="btn btn-primary">
                Submit
              </button>
            </form>
          </div>
        </div>
      </div>
    </main>
  );
};

export default MainView;
