define(["exports", "d3", "fable-core"], function (exports, _d, _fableCore) {
  "use strict";

  exports.__esModule = true;
  exports.input = exports.rSearch = exports.rFocus = exports.rNormal = exports.svg = exports.margin = exports.size = exports.height = exports.width = undefined;
  exports.scaleX = scaleX;
  exports.scaleY = scaleY;
  exports.draw = draw;
  exports.run = run;

  var d3 = _interopRequireWildcard(_d);

  function _interopRequireWildcard(obj) {
    if (obj && obj.__esModule) {
      return obj;
    } else {
      var newObj = {};

      if (obj != null) {
        for (var key in obj) {
          if (Object.prototype.hasOwnProperty.call(obj, key)) newObj[key] = obj[key];
        }
      }

      newObj.default = obj;
      return newObj;
    }
  }

  var patternInput_11 = [1000, 700];
  var width = exports.width = patternInput_11[0];
  var height = exports.height = patternInput_11[1];
  var size = exports.size = [width, height];
  var margin = exports.margin = 100;
  var svg = exports.svg = d3.select("body").append("svg").attr("width", width + 2 * margin).attr("height", height + 2 * margin).attr("class", "graph-svg-component");

  function scaleX(xmin, xrange, x) {
    var xscale = (x - xmin) / xrange;
    return xscale * width + x + margin;
  }

  function scaleY(ymin, yrange, y) {
    var yscale = (y - ymin) / yrange;
    return yscale * height + y + margin;
  }

  var rNormal = exports.rNormal = 3;
  var rFocus = exports.rFocus = 10;
  var rSearch = exports.rSearch = 15;

  function draw(data) {
    console.log("begin drawing data");

    var patternInput = function () {
      var ds = _fableCore.Seq.map(function (d) {
        return d.x;
      }, data);

      return [_fableCore.Seq.reduce(function (x, y) {
        return Math.min(x, y);
      }, ds), _fableCore.Seq.reduce(function (x, y) {
        return Math.max(x, y);
      }, ds)];
    }();

    var xrange = patternInput[1] - patternInput[0];

    var patternInput_1 = function () {
      var ds = _fableCore.Seq.map(function (d) {
        return d.y;
      }, data);

      return [_fableCore.Seq.reduce(function (x, y) {
        return Math.min(x, y);
      }, ds), _fableCore.Seq.reduce(function (x, y) {
        return Math.max(x, y);
      }, ds)];
    }();

    var yrange = patternInput_1[1] - patternInput_1[0];
    var circles = svg.selectAll("circle").data(data).enter().append("circle").attr("r", rNormal).attr("cx", function (delegateArg0, delegateArg1, delegateArg2) {
      return function (d) {
        return function (_arg2) {
          return function (_arg1) {
            return function (x) {
              return scaleX(patternInput[0], xrange, x);
            }(d.x);
          };
        };
      }(delegateArg0)(delegateArg1)(delegateArg2);
    }).attr("cy", function (delegateArg0, delegateArg1, delegateArg2) {
      return function (d) {
        return function (_arg4) {
          return function (_arg3) {
            return function (y) {
              return scaleY(patternInput_1[0], yrange, y);
            }(d.y);
          };
        };
      }(delegateArg0)(delegateArg1)(delegateArg2);
    }).on("mouseover", function (a, b, c) {
      var t = this;
      return function (t) {
        return function (_arg5) {
          return d3.select(t).classed("focus", true).attr("r", rFocus);
        };
      }(t)([a, b, c]);
    }).on("mouseout", function (a, b, c) {
      var t = this;
      return function (t) {
        return function (_arg6) {
          return d3.select(t).classed("focus", false).attr("r", rNormal);
        };
      }(t)([a, b, c]);
    }).attr("id", function (delegateArg0, delegateArg1, delegateArg2) {
      return function (d) {
        return function (_arg8) {
          return function (_arg7) {
            return "name" + d.tag;
          };
        };
      }(delegateArg0)(delegateArg1)(delegateArg2);
    });
    circles.append("title").text(function (delegateArg0, delegateArg1, delegateArg2) {
      return function (d) {
        return function (_arg10) {
          return function (_arg9) {
            return d.tag;
          };
        };
      }(delegateArg0)(delegateArg1)(delegateArg2);
    });
    console.log("finished drawing data");
  }

  d3.json("data/ts.json", function (delegateArg0, delegateArg1) {
    (function (error) {
      return function (data) {
        if (error) {
          throw error;
        } else {
          draw(data);
        }
      };
    })(delegateArg0)(delegateArg1);
  });
  var input = exports.input = document.getElementById("tag");

  function run() {
    d3.selectAll("circle").classed("focus", false).classed("search", false).attr("r", rNormal);
    d3.select("circle[id='name\"" + input.value + "\"']").classed("search", true).attr("r", rSearch);
  }

  input.addEventListener('keyup', function (_arg1) {
    run();
    return null;
  });
});
//# sourceMappingURL=tsne-bubble.js.map