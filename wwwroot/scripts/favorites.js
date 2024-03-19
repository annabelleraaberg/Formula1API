const userFavoriteInput = document.querySelector("#user-favorite-input");
const addFavoriteBtn = document.querySelector("#add-favorite-btn");
const favoriteOutputSection = document.querySelector(
  "#favorite-output-section"
);

/*  Save favorite driver  */
const favoriteDriverArray = JSON.parse(localStorage.getItem("array")) || [];

const saveFavoriteDriver = () => {
  const favorite = userFavoriteInput.value;

  localStorage.setItem("favorite", favorite);

  const newFavorite = {
    favorite: favorite,
  };

  const newFavoriteStringified = JSON.stringify(newFavorite);
  localStorage.setItem("favoriteObject", newFavoriteStringified);
  favoriteDriverArray.push(newFavorite);

  const favoriteArrayStringify = JSON.stringify(favoriteDriverArray);
  localStorage.setItem("array", favoriteArrayStringify);

  console.log(favoriteDriverArray);
  console.log("saveFavoriteDriver");
};

const showLocalStorage = () => {
  favoriteOutputSection.innerHTML = "";

  const favoriteArrayString = localStorage.getItem("array");
  const favoriteDriverArray = JSON.parse(favoriteArrayString) || [];

  if (favoriteDriverArray.length > 0) {
    favoriteOutputSection.innerHTML += "<h4>Your favorites</h4><ul>";

    favoriteDriverArray.forEach((favoriteObject) => {
      const favorite = favoriteObject.favorite;
      favoriteOutputSection.innerHTML += `<li>${favorite}</li>`;
    });

    favoriteOutputSection.innerHTML += "</ul>";
  } else {
    alert("No favorites in localStorage");
  }
};

showLocalStorage();

/*  Event listeners  */
addFavoriteBtn.addEventListener("click", saveFavoriteDriver);
