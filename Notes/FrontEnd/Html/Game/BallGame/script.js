const cards = document.querySelectorAll('.card');

let flippedCard = null;
let lockBoard = false;

cards.forEach(card => card.addEventListener('click', flipCard));

function flipCard() {
    if (lockBoard) return;
    if (this === flippedCard) return;

    this.classList.add('flip');

    if (!flippedCard) {
        flippedCard = this;
        return;
    }

    if (this.dataset.card === flippedCard.dataset.card) {
        this.removeEventListener('click', flipCard);
        flippedCard.removeEventListener('click', flipCard);
        resetBoard();
    } else {
        lockBoard = true;

        setTimeout(() => {
            this.classList.remove('flip');
            flippedCard.classList.remove('flip');
            resetBoard();
        }, 1000);
    }
}

function resetBoard() {
    [flippedCard, lockBoard] = [null, false];
}

(function shuffle() {
    cards.forEach(card => {
        let randomPos = Math.floor(Math.random() * 10);
        card.style.order = randomPos;
    });
})();
