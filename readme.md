# Dash Serializer Example
Example of iterating all JSON properties and URL encoding each one.

## Setup
1. Make sure [.NET Core](https://www.microsoft.com/net/learn/get-started/windows) is installed
2. Install dependencies
   * `dotnet restore`
3. Run the app
   * `dotnet run`
   * Optionally, pass input/output file paths: `dotnet run "./inputJsonFile" "./neato/output-json-file"`

## Example JSON Input
```
{
  "description": {
    "data": [
      {
        "type": "box",
        "xaxis": "x1<>SKD(*#*^&%!&*%~!@#/><",
        "y": [
          -0.91373828,
          1.20546486,
          -0.096304,
          2.37294867
        ],
        "yaxis": "y1"
      },
      {
        "type": "box",
        "xaxis": "x2",
        "y": [
          1.39114565,
          2.42361719,
          0.74492841,
          0.5796092
        ],
        "yaxis": "⇚⇚Shortest Value⇚⇚"
      },
      {
        "showscale": false,
        "type": "heatmap",
        "xaxis": "x3",
        "yaxis": "y3",
        "z": [
          [
            1,
            20,
            30
          ],
          [
            20,
            1,
            60
          ],
          [
            30,
            60,
            1
          ]
        ]
      }
    ],
    "layout": {
      "annotations": [
        {
          "font": {
            "size": 16
          },
          "showarrow": false,
          "text": "First Subplot",
          "x": 0.225,
          "xanchor": "center",
          "xref": "paper",
          "y": 1.0,
          "yanchor": "bottom",
          "yref": "paper"
        },
        {
          "font": {
            "size": 16
          },
          "showarrow": false,
          "text": "Second Subplot",
          "x": 0.775,
          "xanchor": "center",
          "xref": "paper",
          "y": 1.0,
          "yanchor": "bottom",
          "yref": "paper"
        },
        {
          "font": {
            "size": 16
          },
          "showarrow": false,
          "text": "Third Subplot",
          "x": 0.5,
          "xanchor": "center",
          "xref": "paper",
          "y": 0.375,
          "yanchor": "bottom",
          "yref": "paper"
        }
      ],
      "height": 600,
      "title": "i <3 subplots",
      "width": 600,
      "xaxis1": {
        "anchor": "y1",
        "domain": [
          0.0,
          0.45
        ]
      },
      "xaxis2": {
        "anchor": "y2",
        "domain": [
          0.55,
          1.0
        ]
      },
      "xaxis3": {
        "anchor": "y3",
        "domain": [
          0.0,
          1.0
        ]
      },
      "yaxis1": {
        "anchor": "x1",
        "domain": [
          0.625,
          1.0
        ]
      },
      "yaxis2": {
        "anchor": "x2",
        "domain": [
          0.625,
          1.0
        ]
      },
      "yaxis3": {
        "anchor": "x3",
        "domain": [
          0.0,
          0.375
        ]
      }
    }
  },
  "MyBadString": "https://$#@!)(*&@%##"
}
```

## Example JSON Output w/ URL Encoded strings
```
{
  "description": {
    "data": [
      {
        "type": "box",
        "xaxis": "x1%3c%3eSKD(*%23*%5e%26%25!%26*%25%7e!%40%23%2f%3e%3c",
        "y": [ -0.91373828, 1.20546486, -0.096304, 2.37294867 ],
        "yaxis": "y1"
      },
      {
        "type": "box",
        "xaxis": "x2",
        "y": [ 1.39114565, 2.42361719, 0.74492841, 0.5796092 ],
        "yaxis": "%e2%87%9a%e2%87%9aShortest+Value%e2%87%9a%e2%87%9a"
      },
      {
        "showscale": false,
        "type": "heatmap",
        "xaxis": "x3",
        "yaxis": "y3",
        "z": [
          [ 1, 20, 30 ],
          [ 20, 1, 60 ],
          [ 30, 60, 1 ]
        ]
      }
    ],
    "layout": {
      "annotations": [
        {
          "font": { "size": 16 },
          "showarrow": false,
          "text": "First+Subplot",
          "x": 0.225,
          "xanchor": "center",
          "xref": "paper",
          "y": 1.0,
          "yanchor": "bottom",
          "yref": "paper"
        },
        {
          "font": { "size": 16 },
          "showarrow": false,
          "text": "Second+Subplot",
          "x": 0.775,
          "xanchor": "center",
          "xref": "paper",
          "y": 1.0,
          "yanchor": "bottom",
          "yref": "paper"
        },
        {
          "font": { "size": 16 },
          "showarrow": false,
          "text": "Third+Subplot",
          "x": 0.5,
          "xanchor": "center",
          "xref": "paper",
          "y": 0.375,
          "yanchor": "bottom",
          "yref": "paper"
        }
      ],
      "height": 600,
      "title": "i+%3c3+subplots",
      "width": 600,
      "xaxis1": {
        "anchor": "y1",
        "domain": [ 0.0, 0.45 ]
      },
      "xaxis2": {
        "anchor": "y2",
        "domain": [ 0.55, 1.0 ]
      },
      "xaxis3": {
        "anchor": "y3",
        "domain": [ 0.0, 1.0 ]
      },
      "yaxis1": {
        "anchor": "x1",
        "domain": [ 0.625, 1.0 ]
      },
      "yaxis2": {
        "anchor": "x2",
        "domain": [ 0.625, 1.0 ]
      },
      "yaxis3": {
        "anchor": "x3",
        "domain": [ 0.0, 0.375 ]
      }
    }
  },
  "MyBadString": "https%3a%2f%2f%24%23%40!)(*%26%40%25%23%23"
}
```

## Example JSON Output with Decoded Strings
```
{
  "description": {
    "data": [
      {
        "type": "box",
        "xaxis": "x1<>SKD(*#*^&%!&*%~!@#/><",
        "y": [ -0.91373828, 1.20546486, -0.096304, 2.37294867 ],
        "yaxis": "y1"
      },
      {
        "type": "box",
        "xaxis": "x2",
        "y": [ 1.39114565, 2.42361719, 0.74492841, 0.5796092 ],
        "yaxis": "⇚⇚Shortest Value⇚⇚"
      },
      {
        "showscale": false,
        "type": "heatmap",
        "xaxis": "x3",
        "yaxis": "y3",
        "z": [
          [ 1, 20, 30 ],
          [ 20, 1, 60 ],
          [ 30, 60, 1 ]
        ]
      }
    ],
    "layout": {
      "annotations": [
        {
          "font": { "size": 16 },
          "showarrow": false,
          "text": "First Subplot",
          "x": 0.225,
          "xanchor": "center",
          "xref": "paper",
          "y": 1.0,
          "yanchor": "bottom",
          "yref": "paper"
        },
        {
          "font": { "size": 16 },
          "showarrow": false,
          "text": "Second Subplot",
          "x": 0.775,
          "xanchor": "center",
          "xref": "paper",
          "y": 1.0,
          "yanchor": "bottom",
          "yref": "paper"
        },
        {
          "font": { "size": 16 },
          "showarrow": false,
          "text": "Third Subplot",
          "x": 0.5,
          "xanchor": "center",
          "xref": "paper",
          "y": 0.375,
          "yanchor": "bottom",
          "yref": "paper"
        }
      ],
      "height": 600,
      "title": "i <3 subplots",
      "width": 600,
      "xaxis1": {
        "anchor": "y1",
        "domain": [ 0.0, 0.45 ]
      },
      "xaxis2": {
        "anchor": "y2",
        "domain": [ 0.55, 1.0 ]
      },
      "xaxis3": {
        "anchor": "y3",
        "domain": [ 0.0, 1.0 ]
      },
      "yaxis1": {
        "anchor": "x1",
        "domain": [ 0.625, 1.0 ]
      },
      "yaxis2": {
        "anchor": "x2",
        "domain": [ 0.625, 1.0 ]
      },
      "yaxis3": {
        "anchor": "x3",
        "domain": [ 0.0, 0.375 ]
      }
    }
  },
  "MyBadString": "https://$#@!)(*&@%##"
}
```